namespace ModelsCreating.Models
{
    public class Lectures
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public virtual Subject Subject { get; set; } = null!;//навигационка на предмет
        public virtual Teachers Teacher { get; set; } = null!;//навигационка на викладача
        public virtual ICollection<GroupLectures> GroupsLecturesNav { get; set; }
            = new HashSet<GroupLectures>();
    }
}