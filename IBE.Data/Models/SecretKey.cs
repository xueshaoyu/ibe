using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBE.Data.Models
{
    /// <summary>
    /// 秘钥存储系统
    /// </summary>
    public class SecretKey : BaseModel
    {
        /// <summary>
        /// 用户的身份邮箱值
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 用户对应的文件DES加密的秘钥，用于查看原秘钥
        /// </summary>
        public string FileKey { get; set; }
        /// <summary>
        /// 加密后的秘钥
        /// </summary>
        public int EncryptFileKey { get; set; }
        /// <summary>
        /// 身份加密主秘钥
        /// </summary>
        public int IBEMainKey { get; set; }
    }
}