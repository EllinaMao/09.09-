using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsCreating.Models
{
    public class GroupLectures
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int LectureId { get; set; }

        public virtual Lectures LectureNav { get; set; } = null!;
        //навигационка на лекцію
        public virtual Groups GroupNav { get; set; } = null!;//навигационка на групу
    }
}
