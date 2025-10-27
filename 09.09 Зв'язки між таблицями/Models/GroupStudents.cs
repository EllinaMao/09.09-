using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsCreating.Models
{
    public class GroupStudents
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int StudentId { get; set; }
        public virtual Groups GroupNav { get; set; } = null!;//навигационка на групу
        public virtual Students StudentNav { get; set; } = null!;//навигационка на студента
    }
}
