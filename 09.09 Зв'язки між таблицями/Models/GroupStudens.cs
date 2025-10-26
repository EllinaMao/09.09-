using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._09_Зв_язки_між_таблицями.Models
{
    public class GroupStudens
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public Groups Group { get; set; } = null!;//навигационка на групу
        public int StudentId { get; set; }
        public Students Student { get; set; } = null!;//навигационка на студента
    }
}
