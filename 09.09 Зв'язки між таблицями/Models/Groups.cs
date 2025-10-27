using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsCreating.Models
{
    public class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Year { get; set; }
        public int DepartmentId { get; set; }

        public virtual Departments DepartmentNav { get; set; } = null!;// Навигационное свойство
        public virtual ICollection<GroupsCurators> GroupsCuratorsNav { get; set; }
            = new HashSet<GroupsCurators>();
        public virtual ICollection<GroupLectures> GroupsLecturesNav { get; set; }
            = new HashSet<GroupLectures>();
        public virtual ICollection<GroupStudents> GroupsStudentsNav { get; set; }
            = new HashSet<GroupStudents>();
    }
}
