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

        public override string ToString()
        {
            return $"{Name}-{Email}";
        }
    }
}