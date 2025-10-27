using Microsoft.EntityFrameworkCore;
using ModelsCreating.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModelsConfiguring.ModelsConfig
{
    internal class TeachersConfig : IEntityTypeConfiguration<Teachers>
    {
        public void Configure(EntityTypeBuilder<Teachers> builder)
        {
            builder.ToTable("teachers", t =>
            {
                t.HasCheckConstraint("CK_teachers_name_not_empty", "LEN(TRIM(teacher_name)) > 0");
                t.HasCheckConstraint("CK_teachers_surname_not_empty", "LEN(TRIM(teacher_surname)) > 0");
                t.HasCheckConstraint("CK_teachers_salary_positive", "[teacher_salary] > 0");
            });

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id)
                .HasColumnName("teacher_id")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .HasColumnName("teacher_name")
                .HasMaxLength(int.MaxValue)
                .IsRequired();

            builder.Property(t => t.Surname)
                .HasColumnName("teacher_surname")
                .HasMaxLength(int.MaxValue)
                .IsRequired();

            builder.Property(t => t.Salary)
                .HasColumnName("teacher_salary")
                .HasColumnType("money")
                .IsRequired();

            builder.Property(t => t.IsProfessor)
                .IsRequired()
                .HasDefaultValue(false);

        }
    }
}