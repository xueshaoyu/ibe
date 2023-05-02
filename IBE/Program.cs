using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace IBE
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string id = "ime.prezime@mail.hr";
            string messsage = "moram porati posluku";
            Cypher cypher;

            if (args.Length < 2)
            {
               test();
                Console.WriteLine("\n");
                upute();
                return;
            }

            // 配置前置条件
            Setup setup = new Setup();

            if (args[0] == "-f")
            {
                string put = args[1];
                if (!File.Exists(put))
                {
                    messsage = File.ReadAllText(put);
                    if (args.Length != 3)
                    {
                        upute();
                        return;
                    }

                    id = args[args.Length - 1];

                    encode(messsage, id, setup);
                }
                else
                {
                    Console.WriteLine("File does not exists!\n");
                    upute();
                    return;
                }
            }

            string sif;
            string xs;
            string ys;

            if (args[1] == "-d")
            {
                if (args[1] == "-f" && args.Length == 6)
                {
                    string put = args[2];
                    sif = File.ReadAllText(put);

                    id = args[args.Length - 1];
                    xs = args[3];
                    ys = args[4];
                }
                else if (args.Length > 6 || args.Length != 5)
                {
                    upute();
                    return;
                }
                else
                {
                    sif = args[1];
                    xs = args[2];
                    ys = args[3];
                    id = args[args.Length - 1];
                }

                BigInteger x1 = new BigInteger(xs, 10);
                BigInteger y1 = new BigInteger(ys, 10);

                FpFieldElement x = (FpFieldElement)setup.E.FromBigInteger(x1);
                FpFieldElement y = (FpFieldElement)setup.E.FromBigInteger(y1);

                FpPoint point = new FpPoint(setup.E, x, y);

                cypher = new Cypher { U = point, V = sif };

                decode(cypher, id, setup);
            }
            else
            {
                messsage = "";
                for (int i = 1; i < args.Length - 2; i++)
                {
                    messsage += args[i] + " ";
                }
                messsage += args[args.Length - 2];

                id = args[args.Length - 1];

                encode(messsage, id, setup);
            }

            Console.ReadKey();
        }

        /// <summary>
        ///  解密
        /// </summary>
        /// <param name="cypher"></param>
        /// <param name="id"></param>
        /// <param name="setup"></param>
        private static void decode(Cypher cypher, string id, Setup setup)
        {
            // 秘钥
            FpPoint d_id = setup.Exctract(id, true);

            Decrypt d = new Decrypt(d_id, setup.p, setup.k);
            string msg = d.GetMessage(cypher);

            Console.Out.WriteLine("decoded: \"" + msg + "\"");
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="id"></param>
        /// <param name="setup"></param>
        private static void encode(string msg, string id, Setup setup)
        {
            Encrypt e = new Encrypt(id, setup.GetP(), setup.GetPpub(), setup.p, setup.E, setup.k);

            Cypher c = e.GetCypher(msg);

            Console.Out.WriteLine("message: \"" + msg + "\"");
            Console.Out.WriteLine("cypher: \"" + c.V + "\"");
            Console.Out.WriteLine("point: \"(" + c.U.X.ToBigInteger().ToString(16) + " ,\n\t" + c.U.Y.ToBigInteger().ToString(16) + "\"");
            decode(c, id, setup);
        }

        private static void test()
        {
            Console.Out.WriteLine("开始!");
            Setup setup; FpPoint d_id;
            var id = "75668578999@qq.com";
            var id1 = "ime.prezime@mail.hr";
            //while (true)
            //{
            //    // 配置前置条件
            setup = new Setup();
            //    // 解密密钥
                d_id = setup.Exctract(id);

            //    Encrypt e = new Encrypt("ime.prezime@mail.hr", setup.GetP(), setup.GetPpub(), setup.p, setup.E, setup.k);

            //    string msg = "测是、sstete";
            //    Cypher c = e.GetCypher(msg);

            //    Console.Out.WriteLine("原消息: \"" + msg + "\"");
            //    Console.Out.WriteLine("加密后消息: \"" + c.V + "\"");
            //    Console.Out.WriteLine("点: \"(" + c.U.X.ToBigInteger().ToString(16) + " ,\n\t" + c.U.Y.ToBigInteger().ToString(16) + "\"");
            //    Decrypt d = new Decrypt(d_id, setup.p, setup.k);
            //    string demsg = d.GetMessage(c);
            //    Console.Out.WriteLine("解密: \"" + demsg + "\"");
            //    if (demsg == msg)
            //    {
            //        break;
            //    }
            //}
            // 解密密钥
            // FpPoint d_id1 = setup.Exctract("ime.prezime@mail.hr");
            while (true)
            {
                var msgtt = "测是、sstete";
                Encrypt e = new Encrypt(id, setup.GetP(), setup.GetPpub(), setup.p, setup.E, setup.k);
                Cypher c = e.GetCypher(msgtt);
                
                Decrypt d = new Decrypt(d_id, setup.p, setup.k);
                string demsg = d.GetMessage(c);
                Console.Out.WriteLine($"源：{c.V},解：{demsg},结果:{msgtt == demsg}");
                Thread.Sleep(10);
            }
            //Decrypt d = new Decrypt(d_id, setup.p, setup.k);
            //string demsg = d.GetMessage(c);

            //Console.Out.WriteLine("解密: \"" + demsg + "\"");

            Console.ReadKey();
        }

        private static void upute()
        {
            Console.WriteLine("使用:\nIBE [-d -f] [message | path | cypher] [pointX pointY] ID");
            Console.WriteLine("加密: IBE [-f path] message ID");
            Console.WriteLine("\t-f - 加密文件");
            Console.WriteLine("\tpath - 文件路径");
            Console.WriteLine("\tmessage - 字符串加密");
            Console.WriteLine("\tID - 身份id");
            Console.WriteLine("示例:\n\tIBE 这是针对 secret.mail@gmail.com的加密消息");
            Console.WriteLine("\tIBE -f C:\\secret secret.mail@gmail.com");
            Console.WriteLine();

            Console.WriteLine("解密: IBE -d [-f path] cypher pointX pointY ID");
            Console.WriteLine("\tpointX pointY - first and second point parameters of cypher");
            Console.WriteLine("示例:\nIBE -d $OH$&)=9-*/=BDO adc70903da987d fed1ad07d6a8d6 secret.mail@gmail.com");

            Console.ReadKey();
        }
    }
}