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
        public static string Decode(string x,string y,string demsg, string id)
        {
            // 秘钥
            var setup = new Setup();
            setup.EnsureMainKeyRight(id);
            // 解密密钥 
            var d_id = setup.Exctract(id,true);

            BigInteger x1 = new BigInteger(x, 10);
            BigInteger y1 = new BigInteger(y, 10);

            FpFieldElement fx = (FpFieldElement)setup.E.FromBigInteger(x1);
            FpFieldElement fy = (FpFieldElement)setup.E.FromBigInteger(y1);

            FpPoint point = new FpPoint(setup.E, fx, fy);

            Cypher c = new Cypher()
            {
                U =  setup.GetP(),
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
        public static Cypher Encode(string msg, string id)
        {
            var setup = new Setup();
            setup.EnsureMainKeyRight(id); 
             
            Encrypt e = new Encrypt(id, setup.GetP(), setup.GetPpub(), setup.p, setup.E, setup.k);
            Cypher c = e.GetCypher(msg); 

            return c;

        }
    }
}
