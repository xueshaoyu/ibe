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
        public MyDbContext() : base(ConfigurationManager.ConnectionStrings["SQLServerConnection"].ToString())
        {
        }

        static MyDbContext()
        {
            Instance = new MyDbContext();
        }

        public static MyDbContext Instance { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<SecretKey> SecretKeys { get; set; }
        public DbSet<ExchangeFileData> ExchangeFileDatas { get; set; }
        
        /// <summary>
        /// 初始化数据
        /// </summary>
        public void InitData()
        {
            if (Instance.Managers.Count() == 0)
            {
                Instance.Managers.Add(new Manager() { Name = "超级管理员", LoginAccount = "admin", Password = "admin", AllowDelete = false });
            }
            if (Instance.Teachers.Count() == 0)
            {
                Instance.Teachers.Add(new Teacher() { Name = "测试教师", LoginAccount = "teacher01", Password = "teacher01", Email = "teacher01@qq.com" });
            }
            if (Instance.Students.Count() == 0)
            {
                Instance.Students.Add(new Student() { Name = "测试学生", LoginAccount = "student01", Password = "student01", Email = "student01@qq.com" });
            }
            Instance.SaveChanges();
        }
    }
}