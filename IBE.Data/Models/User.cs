using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBE.Data.Models
{
    /// <summary>
    /// 学生
    /// </summary>
    public class User : BaseModel
    {
        public string Name { get; set; }
        [Required]
        public string LoginAccount { get; set; }
        public string Password { get; set; }
        [Required] 
        public string Email { get; set; }
        /// <summary>
        /// 找回密码码第一个问题
        /// </summary>
        public string FirstQuestion { get; set; }
        public string SecondQuestion { get; set; }
        public string ThirdQuestion { get; set; }
        /// <summary>
        /// 找回密码码第一个回答
        /// </summary>
        public string FirstAnswer { get; set; }
        public string SecondAnswer { get; set; }
        public string ThirdAnswer { get; set; }
        /// <summary>
        /// 启用、禁用
        /// </summary>
        public bool Enable { get; set; } = true;

        public override string ToString()
        {
            return $"姓名：{Name}-登录账号：{LoginAccount}-邮箱：{Email}";
        }
    }
}