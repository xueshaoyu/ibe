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
        /// 用户的邮箱值
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 解密秘钥
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 主密钥
        /// </summary>
        public int MainKey { get; set; }
    }
}