using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBE.Data.Models
{
    /// <summary>
    /// 系统管理员
    /// </summary>
    public class Manager : BaseModel
    {
        public string Name { get; set; }
        public string LoginAccount { get; set; }

        public string Password { get; set; }
        public bool AllowDelete { get; set; } = true;

    }
}