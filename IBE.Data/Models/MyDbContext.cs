using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace IBE.Data.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base(ConfigurationManager.AppSettings["SQLServerConnection"].ToString())
        {
        }

        static MyDbContext()
        {
            Instance = new MyDbContext();
        }

        public static MyDbContext Instance { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Manager> Managers { get; set; }

        /// <summary>
        /// 初始化数据
        /// </summary>
        public void InitData()
        {
            if (Instance.Managers.Count() == 0)
            {
                Instance.Managers.Add(new Manager() { Name = "超级管理员", LoginAccount = "admin", Password = "admin", AllowDelete = false }); ;
            }
        }
    }
}