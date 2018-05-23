using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace yearn.modules.domainobjects
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Student { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../yearn.db");
        }
    }
}
