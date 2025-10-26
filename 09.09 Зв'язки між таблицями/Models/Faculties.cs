namespace _09._09_Зв_язки_між_таблицями.Models
{
    public class Faculties
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public List<Departments> Departments { get; set; } = new List<Departments>();//это навигационка на кафедры, помни
    }
}