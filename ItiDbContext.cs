using EF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    internal class ItiDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=ITIDB;Trusted_Connection=true;TrustServerCertificate =true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Inst>().HasKey(ci => new {ci.inst_ID,ci.Course_ID});
            modelBuilder.Entity<Stud_Course>().HasKey(sc => new { sc.stud_ID, sc.Course_ID });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get;set; }
        public DbSet<Topic> Topics { get; set; }

    }
}
