using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09._09_Зв_язки_між_таблицями.Models;
using Microsoft.EntityFrameworkCore;

namespace _09._09_Зв_язки_між_таблицями.ModelsConfig
{
    public class DbContext
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
        public DbSet<GroupStudens> GroupStudens { get; set; } = null!;



    }
}
