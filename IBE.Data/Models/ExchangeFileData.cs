using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBE.Data.Models
{
    /// <summary>
    /// 文件交换信息
    /// </summary>
    public class ExchangeFileData : BaseModel
    {
        /// <summary>
        /// 发送人
        /// </summary>
        public string Sender { get; set; }
        /// <summary>
        /// 目标邮箱地址
        /// </summary>
        public string DestEmail { get; set; }
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
        /// 是否已下载
        /// </summary>

        public bool IsDowload { get; set; }

        /// <summary>
        /// 是否发送给自己的文件
        /// </summary>
        [NotMapped]
        public bool IsSendMe { get; set; }

        public override string ToString()
        {
            return $"来自：{Sender ?? "未知"},发送给：{DestEmail}的文件，文件名称：{FileName}-状态：{(IsDowload ? "已下载" : "未下载")}-发送时间：{Time.ToString("yyyy-MM-dd HH:mm:ss")}";
        }
    }
}
