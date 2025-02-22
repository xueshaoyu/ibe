﻿using IBE.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBE.UI
{
    /// <summary>
    /// 登录绘画管理
    /// </summary>
   public static  class SessionManager
    {

        public static Manager Manager { get; set; }
        public static User User { get; set; } 
        /// <summary>
        /// 清除登录信息
        /// </summary>
        public static void Clear() {
            Manager = null;
            User = null; 
        }
    }
}
