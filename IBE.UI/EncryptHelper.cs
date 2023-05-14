using IBE.Data.Models;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IBE.UI
{
    /// <summary>
    /// 加解密帮助类
    /// </summary>
    public class EncryptHelper
    { 
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="email">邮箱</param>
        private static void EnsureIbeMainKeyRight(string email)
        {
            var setup = new Setup();
            setup.EnsureMainKeyRight(email);             
         
        }
        /// <summary>
        /// 通过邮箱获取文件对称加密的秘钥
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static string GetDesKeyByEmail(string email)
        {
            EnsureIbeMainKeyRight(email);
            var secretKey=  MyDbContext.Instance.SecretKeys.FirstOrDefault(p => p.Email == email);
            var setup = new Setup();

            BigInteger mtp = new BigInteger(secretKey.IBEMainKey.ToString(), 10);
           var Ppub = (FpPoint)setup.GetP().Multiply(mtp);
            setup.SetPpub(Ppub);
             
            var d_id = setup. Exctract(email,true); 

            var d = new Decrypt(d_id, setup.p, setup.k);
            var x = new BigInteger(secretKey.IBEX, 10);
            var y = new BigInteger(secretKey.IBEY, 10);
            FpFieldElement x_Qid = new FpFieldElement(setup.p, x);
            FpFieldElement y_Qid = new FpFieldElement(setup.p, y);
            Cypher c = new Cypher() { U = new FpPoint(setup.E, x_Qid, y_Qid), V = secretKey.EncryptFileKey };             
            string rmsg = d.GetMessage(c);
            return secretKey.FileKey;
        }

        
    }
}
