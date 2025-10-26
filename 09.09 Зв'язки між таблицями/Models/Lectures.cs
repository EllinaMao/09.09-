namespace _09._09_Зв_язки_між_таблицями.Models
{
    public class Lectures
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public Subject Subject { get; set; } = null!;//навигационка на предмет
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public Teachers Teacher { get; set; } = null!;//навигационка на викладача
    }
}