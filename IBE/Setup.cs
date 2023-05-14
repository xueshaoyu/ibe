using IBE.Data.Models;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using System;
using System.IO;
using System.Text;
using System.Linq;

namespace IBE
{
    public class Setup
    {
        // 定义它的用途
        /*
            E - 曲线 secp256k1 - y^2 = x^3+0*x+7 - http://safecurves.cr.yp.to/equation.html
            q - p /// p^n
            p - prost broj - za secp256k1 je 2^256 - 2^32 - 977  = 115792089237316195423570985008687907853269984665640564039457584007908834671663
            Fq - polje nad kojim se računa
            E(Fq) - grupa u kojoj je krivulja E nad poljem Fq
            k - red grupe E(Fq) - 115792089237316195423570985008687907852837564279074904382605163141518161494337
            H1 - sha256(<string>) mod p -> x 值; y 值
            H2 - ripemd-120 : točka iz polja -> niz bita mod p
            e - Weilovo uparivanje
            P - 随机曲线点 (x1,y1) - 起点
            Ppub - 公钥 - Ppub = sP
            s - 主秘钥 - 随机数 iz Zq i != 0
        */

        // 随机 P iz E(Fq) - G1
        // 建议使用secp256k1: P = (55066263022277343669578718895168534326250603453777594175500187360389116729240,
        //                             32670510020758816978083085130507043184471273380659243275938904335757337482424)
        // BigInteger(<broj>,<baza>)
        private FpPoint P;

        // k
        public BigInteger k { get; }

        // n
        public int n { get; }

        // q
        private BigInteger q;

        // p
        public BigInteger p { get; } 

        /// <summary>
        /// 曲线
        /// </summary>
        public FpCurve E { get; }

        /// <summary>
        /// 随机数,主秘钥
        /// </summary>
        private int s = 0;

        /// <summary>
        /// 公钥
        /// </summary>
        private FpPoint Ppub;
        private string mainKeyPath = "main.key";
        public Setup()
        {
            n = 3;


            // p i q
            // p i q
            //p = new BigInteger("115792089237316195423570985008687907853269984665640564039457584007908834671663", 10);
            p = new BigInteger("115792089237316195423570985008687907853269984665640564039457584007908834671663", 10);
            //q = p.Pow(3);
            //q = p.Pow(1);
            q = p;

            k = new BigInteger("115792089237316195423570985008687907852837564279074904382605163141518161494337", 10);

            // E - 曲线公式 secp256k1 - y ^ 2 = x ^ 3 + 0*x + 7
            BigInteger a = new BigInteger("0", 10);
            BigInteger b = new BigInteger("7", 10);
            E = new FpCurve(q, a, b);

            // P
            BigInteger x1 = new BigInteger("55066263022277343669578718895168534326250603453777594175500187360389116729240", 10);
            BigInteger y1 = new BigInteger("32670510020758816978083085130507043184471273380659243275938904335757337482424", 10);
            FpFieldElement x = (FpFieldElement)E.FromBigInteger(x1); // new FpFieldElement(q, x1);
            FpFieldElement y = (FpFieldElement)E.FromBigInteger(y1); // new FpFieldElement(q, y1);

            P = new FpPoint(E, x, y);

        }
        /// <summary>
        /// 保证随机数可用,能够解出加密信息
        /// </summary>
        public void EnsureMainKeyRight(string email)
        { 
            var secretKey = MyDbContext.Instance.SecretKeys.FirstOrDefault(p => p.Email == email);
            var count = 0;
            if (secretKey != null)
            {
                s = secretKey.IBEMainKey;
                BigInteger mtp = new BigInteger(s.ToString(), 10);
                Ppub = (FpPoint)P.Multiply(mtp);
            }
            else
            {//生成一个可以有解的随机数作为主密钥
            start:
               do
                {
                    Random r = new Random();
                    s = r.Next(1, int.MaxValue - 1);
                } while (s == 0);

                BigInteger mtp = new BigInteger(s.ToString(), 10);
                Ppub = (FpPoint)P.Multiply(mtp);

                var msg = "hello,你好hello,你好hello,你好hello,你好hello,你好";
              

                Encrypt e = new Encrypt(email, GetP(), GetPpub(), p, E, k);
                var d_id = Exctract(email);
                var dmsg = e.GetCypher(msg);

                var d = new Decrypt(d_id, p, k);
                Cypher c = new Cypher()
                {
                    V = dmsg.V,
                    U = GetP()
                };
                string rmsg = d.GetMessage(c);

                while (rmsg != msg)
                {
                    count++;
                    if (File.Exists(mainKeyPath))
                        File.Delete(mainKeyPath);
                    goto start;
                }
                if (secretKey == null)
                {
                    secretKey = new SecretKey();
                    secretKey.Email = email;
                    secretKey.IBEMainKey = s;
                    secretKey.IBEX = dmsg.U.X.ToBigInteger().ToString();
                    secretKey.IBEY = dmsg.U.Y.ToBigInteger().ToString();
                    secretKey.FileKey = RandomHelper.GenerateRandomNumber(10);
                    var temp = e.GetCypher(secretKey.FileKey);
                    secretKey.EncryptFileKey = temp.V;
                    MyDbContext.Instance.SecretKeys.Add(secretKey);
                    MyDbContext.Instance.SaveChanges();
                }
            }
        }


        /// <summary>
        /// 获取私钥
        /// </summary>
        /// <returns></returns>
        public FpPoint GetP()
        {
            return P;
        }

        /// <summary>
        /// 获取公钥
        /// </summary>
        /// <returns></returns>
        public FpPoint GetPpub()
        {
            return Ppub;
        }
        /// <summary>
        /// 设置公钥
        /// </summary>
        /// <param name="value"></param>
        public void SetPpub(FpPoint value)
        {
              Ppub=value;
        }
        /// <summary>
        /// 颁发私钥
        /// </summary>
        /// <param name="email"></param>
        /// <param name="decrypt">是否解密</param>
        /// <returns></returns>
        public FpPoint Exctract(string email, bool decrypt = false)
        {
            if (decrypt)
            {
                var secretKey = MyDbContext.Instance.SecretKeys.FirstOrDefault(p => p.Email == email);
                if (secretKey != null)
                {
                    s = secretKey.IBEMainKey;
                }
                else
                {

                    throw new Exception("该用户不能解密");
                }
            }

            //  y^2 = x^3 + 117050x^2 + x
            //	            y ^ 2 = x ^ 3 + 229969x ^ 2 + x 这个公式不容易出现解不出的情况
            BigInteger x = GeneralFunctions.H1hash(email, p);
            BigInteger y = x.Pow(3).Add(x.Pow(2).Multiply(new BigInteger("117050", 10))).Add(x).Pow(2).ModInverse(p);
            // BigInteger y = x.Pow(3).Add(x.Pow(2).Multiply(new BigInteger("117050", 10))).Add(x).Pow(2).ModInverse(p);
            //BigInteger y = x.Pow(3).Add(x.Pow(2).Multiply(new BigInteger("0", 10))).Add(x).Pow(2).ModInverse(p);

            FpFieldElement x_Qid = new FpFieldElement(q, x);
            FpFieldElement y_Qid = new FpFieldElement(q, y);
            FpPoint Qid = new FpPoint(E, x_Qid, y_Qid);

            FpPoint d_id = (FpPoint)Qid.Multiply(new BigInteger(s.ToString(), 10));
           
            // 私钥
            return d_id;
        }
    }
}