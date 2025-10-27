
namespace ModelsCreating.Models
{
    public class Departments
    {
        public int Id { get; set; } 
        public int Building { get; set; }
        public decimal Financing { get; set; } = 0;
        public string Name { get; set; } = null!;
        public int FacultyId {  get; set; }
        public virtual Faculties FacultyNav { get; set; } = null!; // Навигационное свойство
        public virtual ICollection<Groups> GroupNav { get; set; }
            = new HashSet<Groups>();
    }
}
