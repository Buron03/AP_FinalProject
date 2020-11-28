using System;
using Microsoft.EntityFrameworkCore;

using AppContext.Models;

namespace AppContext
{
    public class School : DbContext
    {
        public DbSet<TeacherKind> TeacherKinds { get; set; }
        public DbSet<PeriodKind> PeriodKinds { get; set; }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SchoolGroup> SchoolGroups { get; set; }

        public DbSet<TeacherSubject> TeacherSubjects { get; set; }
        public DbSet<Assignature> Assignatures { get; set; }


        public School(DbContextOptions<School> options)
        :base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "../Database/Example/School.db";
            optionsBuilder.UseSqlite($"Filename = {path}");
        }
    }
}
