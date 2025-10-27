using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09._09_Зв_язки_між_таблицями.Models
{
    public class Departments
    {
        public int Id { get; set; } 
        public int Building { get; set; }
        public decimal Financing { get; set; } = 0;
        public string Name { get; set; } = null!;
        public int FacultyId {  get; set; }
        public virtual Faculties Faculty { get; set; } = null!; // Навигационное свойство
        public virtual ICollection<Group> Groups { get; set; }
            = new HashSet<Group>();
    }
}
