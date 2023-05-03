using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBE.Data.Models
{
    /// <summary>
    /// 学生
    /// </summary>
    public class Student : BaseModel
    {
        public string Name { get; set; }
        public string LoginAccount { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Name}-{Email}";
        }
    }
}