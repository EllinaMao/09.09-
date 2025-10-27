using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using ModelsConfiguring.ModelsConfig;
using ModelsCreating.Models;
using NLog.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseModels
{
    //Наследуемся от Microsoft.EntityFrameworkCore.DbContext
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Departments> Departments { get; set; } = null!;
        public DbSet<Faculties> Faculties { get; set; } = null!;
        public DbSet<Curators> Curators { get; set; } = null!;
        public DbSet<Groups> Groups { get; set; } = null!;
        public DbSet<Students> Students { get; set; } = null!;
        public DbSet<Subject> Subjects { get; set; } = null!;
        public DbSet<Lectures> Lectures { get; set; } = null!;
        public DbSet<Teachers> Teachers { get; set; } = null!;
        public DbSet<GroupsCurators> GroupsCurators { get; set; } = null!;
        public DbSet<GroupLectures> GroupLectures { get; set; } = null!;
        public DbSet<GroupStudents> GroupStudens { get; set; } = null!;
        #region Constructor
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentsConfig());
            modelBuilder.ApplyConfiguration(new FacultiesConfig());
            modelBuilder.ApplyConfiguration(new CuratorsConfig());
            modelBuilder.ApplyConfiguration(new GroupsConfig());
            modelBuilder.ApplyConfiguration(new StudentsConfig());
            modelBuilder.ApplyConfiguration(new SubjectConfig());
            modelBuilder.ApplyConfiguration(new LecturesConfig());
            modelBuilder.ApplyConfiguration(new TeachersConfig());
            modelBuilder.ApplyConfiguration(new GroupsCuratorsConfig());
            modelBuilder.ApplyConfiguration(new GroupLecturesConfig());
            modelBuilder.ApplyConfiguration(new GroupStudensConfig());
        }
        #endregion

    }
}
