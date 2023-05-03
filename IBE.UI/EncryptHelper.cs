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
        ///  解密
        /// </summary>
        /// <param name="demsg"></param>
        /// <param name="id"></param>
        public static string Decode(string demsg, string id)
        {
            // 秘钥
            var setup = new Setup();
            // 解密密钥 
            var d_id = setup.Exctract(id,true);

            var point = setup.GetPpub();
          //  var c = new Cypher { U = point, V = demsg };
            //var t = setup.GetPpub();
            //Console.Out.WriteLine("decode1 point: \"(" + c.U.X.ToBigInteger().ToString(16) + " ,\n\t" + c.U.Y.ToBigInteger().ToString(16) + "\"");

            //Console.Out.WriteLine("decode2 point: \"(" + t.X.ToBigInteger().ToString(16) + " ,\n\t" + t.Y.ToBigInteger().ToString(16) + "\"");
            Encrypt e = new Encrypt(id, setup.GetP(), setup.GetPpub(), setup.p, setup.E, setup.k);
            Cypher c = new Cypher()
            {
                U = setup.GetP(),
                V = demsg
            };
            var d = new Decrypt(d_id, setup.p, setup.k);
            string msg = d.GetMessage(c);
           
            return msg;
        }

       
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="id"></param>
        public static string Encode(string msg, string id)
        {
            var setup = new Setup();
            setup.EnsureMainKeyRight(id); 

            var msgtt = msg; 
            Encrypt e = new Encrypt(id, setup.GetP(), setup.GetPpub(), setup.p, setup.E, setup.k);
            Cypher c = e.GetCypher(msgtt); 

            return c.V;

        }
    }
}
