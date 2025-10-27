using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09._09_Зв_язки_між_таблицями.Models;
using Microsoft.EntityFrameworkCore;

namespace _09._09_Зв_язки_між_таблицями.ModelsConfig
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
            // Здесь должна быть ваша строка подключения
            //optionsBuilder.UseSqlServer("Server=YourServerName;Database=UniversityDb;Trusted_Connection=True;");
            // сделать иксемель конфиг, не быть ленивой жопой
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
