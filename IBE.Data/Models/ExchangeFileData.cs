using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBE.Data.Models
{
    /// <summary>
    /// 文件交换信息
    /// </summary>
    public class ExchangeFileData:BaseModel
    {
        /// <summary>
        /// 发送人
        /// </summary>
        public string Sender { get; set; }
        /// <summary>
        /// 目标邮箱地址
        /// </summary>
        public string DestEmail{get;set; }
        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 加密文件路径
        /// </summary>
        public string EncryptFilePath { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Time { get; set; } = DateTime.Now;
        /// <summary>
        /// 是否已读
        /// </summary>

        public bool IsRead { get; set; }


        public override string ToString()
        {
            return $"来自：{Sender??"未知"}，文件名：{FileName}-{(IsRead?"已读":"未读")}-{Time.ToString("yyyy-MM-dd HH:mm:ss")}";
        }
    }
}
