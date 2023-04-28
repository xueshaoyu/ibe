using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBE.Data.Models
{
    /// <summary>
    /// 老师
    /// </summary>
    public class Teacher : BaseModel
    {
        public string Name { get; set; }
        public string LoginAccount { get; set; }
        public string Password { get; set; }

        public virtual Role Role { get; set; }
    }
}