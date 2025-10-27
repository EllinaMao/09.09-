using _09._09_Зв_язки_між_таблицями.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._09_Зв_язки_між_таблицями
{

    public class Curators
    {
        public int Id {  get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public virtual ICollection<GroupsCurators> GroupsCurators { get; set; }
            = new HashSet<GroupsCurators>();
    }
}
