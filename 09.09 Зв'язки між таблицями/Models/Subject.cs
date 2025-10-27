namespace ModelsCreating.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Lectures> LecturesNav { get; set; }
            = new HashSet<Lectures>();
    }
}