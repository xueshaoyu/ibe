using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBE.Models
{
   public class Teacher : BaseModel
    {
        public string Name { get; set; }

        public virtual Role Role { get; set; }
    }
}
