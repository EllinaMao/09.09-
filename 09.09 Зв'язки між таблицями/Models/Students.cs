namespace ModelsCreating.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public string Surname { get; set; } = null!;
        public virtual ICollection<GroupStudents> GroupsStudentsNav { get; set; }
            = new HashSet<GroupStudents>();
    }
}