namespace _09._09_Зв_язки_між_таблицями.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Lectures> Lectures { get; set; }
            = new HashSet<Lectures>();
    }
}