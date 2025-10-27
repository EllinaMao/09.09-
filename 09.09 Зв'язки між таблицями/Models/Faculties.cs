namespace ModelsCreating.Models
{
    public class Faculties
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Departments> DepartmentsNav { get; set; } = new HashSet<Departments>();//навигационка на департаменты
    }
}