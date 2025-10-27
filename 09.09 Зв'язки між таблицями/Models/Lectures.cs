namespace _09._09_Зв_язки_між_таблицями.Models
{
    public class Lectures
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public virtual Subject Subject { get; set; } = null!;//навигационка на предмет
        public virtual Teachers Teacher { get; set; } = null!;//навигационка на викладача
        public virtual ICollection<GroupLectures> GroupsLectures { get; set; }
            = new HashSet<GroupLectures>();
    }
}