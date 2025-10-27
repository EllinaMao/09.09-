using _09._09_Зв_язки_між_таблицями.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _09._09_Зв_язки_між_таблицями.ModelsConfig
{
    internal class StudentsConfig : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            builder.ToTable("students", t =>
            {
                t.HasCheckConstraint("CK_students_name_not_empty", "LEN(TRIM(student_name)) > 0");
                t.HasCheckConstraint("CK_students_surname_not_empty", "LEN(TRIM(student_surname)) > 0");
                t.HasCheckConstraint("CK_students_rating_range", "[student_rating] BETWEEN 0 AND 5");
            });
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id)
                .HasColumnName("student_id")
                .ValueGeneratedOnAdd();

            builder.Property(s => s.Name)
                .HasColumnName("student_name")
                .HasMaxLength(int.MaxValue)
                .IsRequired();

            builder.Property(s => s.Surname)
                .HasColumnName("student_surname")
                .HasMaxLength(int.MaxValue)
                .IsRequired();

            builder.Property(s => s.Rating)
                .HasColumnName("student_rating")
                .IsRequired();

        }
    }
}