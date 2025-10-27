namespace _09._09_Зв_язки_між_таблицями.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public string Surname { get; set; } = null!;
        public virtual ICollection<GroupStudents> GroupsStudents { get; set; }
            = new HashSet<GroupStudents>();
    }
}