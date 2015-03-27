using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CodeFirstSample.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
            : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> EnrollMents { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}