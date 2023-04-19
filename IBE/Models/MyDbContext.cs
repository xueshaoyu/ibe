
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Text;

namespace IBE.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base(ConfigurationManager.AppSettings["SQLServerConnection"].ToString())
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}