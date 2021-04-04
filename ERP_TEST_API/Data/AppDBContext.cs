using ERP_TEST.Model;
using ERP_TEST.Model.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_TEST_API.Data
{
    public class AppDBContext:DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<Part> Part { get; set; }
        public DbSet<Staff> Staff { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string abc = "Data Source=DESKTOP-2B0R6AS\\SQLEXPRESS01;Initial Catalog=ERP_TEST;Integrated Security=True";
            optionsBuilder.UseSqlServer(abc);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser>()
                .ToTable("AspNetUsers", t => t.ExcludeFromMigrations());
        }
    }
}
