namespace ModelsCreating.Models
{
    public class Teachers
    {
        public int Id { get; set; }
        public bool IsProfessor { get; set; }
        public string Name { get; set; } = null!;
        public decimal Salary { get; set; }
        public string Surname { get; set; } = null!;
        public virtual ICollection<Lectures> LecturesNav { get; set; }
            = new HashSet<Lectures>();
    }
}