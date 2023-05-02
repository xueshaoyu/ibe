using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IBE
{
    public class EncryptHelper
    {
        /// <summary>
        /// 用于判断是否解密成功的前缀字符串
        /// </summary>
        static string preStr = "!3!!456=798ofddr90898786574532465789philhvgc@$#%^&3";

        /// <summary>
        ///  解密
        /// </summary>
        /// <param name="demsg"></param>
        /// <param name="id"></param>
        public static string Decode(string demsg, string id)
        {
            checkId(ref id);
            // 秘钥
            var setup = new Setup();
            // 解密密钥 
            var d_id = setup.Exctract(id, true);
           
            var point = setup.GetP();
            var cypher = new Cypher { U = point, V = demsg };
            Decrypt d = new Decrypt(d_id, setup.p, setup.k);
           
            string msg = d.GetMessage(cypher);
            while(!msg.StartsWith(preStr))
            {
                msg = d.GetMessage(cypher);
            }
            return msg;
        }
        private static Cypher Enc;

        private static void checkId(ref string id)
        {
            while (Encoding.UTF8.GetByteCount(id) < 18)
            {
                id += "_";
            }
        }
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="id"></param>
        public static string Encode(string msg, string id)
        {
            msg = preStr + msg;
            var setup = new Setup();
            checkId(ref id);
            //Encrypt e = new Encrypt(id, setup.GetP(), setup.GetPpub(), setup.p, setup.E, setup.k);
            //Cypher c = e.GetCypher(msg);
            //
            //var d_id = setup.Exctract(id, true);
            //Decrypt d = new Decrypt(d_id, setup.p, setup.k);
            //
            //var msg1 = d.GetMessage(c);

            var d_id = setup.Exctract(id);
            var msgtt = msg;
            Encrypt e = new Encrypt(id, setup.GetP(), setup.GetPpub(), setup.p, setup.E, setup.k);
            Cypher c = e.GetCypher(msgtt);

            while (true)
            {

                Decrypt d = new Decrypt(d_id, setup.p, setup.k);
                string demsg = d.GetMessage(c);
                Console.Out.WriteLine($"源：{c.V},解：{demsg},结果:{msgtt == demsg}");
                Thread.Sleep(10);
            }
           // return c.V;
            return "";

        }
    }
}
