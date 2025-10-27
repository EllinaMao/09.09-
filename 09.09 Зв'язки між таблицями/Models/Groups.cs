using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._09_Зв_язки_між_таблицями.Models
{
    public class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Year { get; set; }
        public int DepartmentId { get; set; }
        public Departments Department { get; set; } = null!;

        public virtual Departments Departments { get; set; } // Навигационное свойство

        public virtual ICollection<GroupsCurators> GroupsCurators { get; set; }
            = new HashSet<GroupsCurators>();
        public virtual ICollection<GroupLectures> GroupsLectures { get; set; }
            = new HashSet<GroupLectures>();
        public virtual ICollection<GroupStudents> GroupsStudents { get; set; }
            = new HashSet<GroupStudents>();
    }
}
