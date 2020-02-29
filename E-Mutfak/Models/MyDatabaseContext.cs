using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Mutfak.Models
{
    public class MyDatabaseContext : DbContext
    {
        public DbSet<User> users { get; set; }

        public MyDatabaseContext() : base("name=MyDbConnection")
        {

        }
    }
}