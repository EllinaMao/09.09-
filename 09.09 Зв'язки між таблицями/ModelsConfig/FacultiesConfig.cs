using _09._09_Зв_язки_між_таблицями.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _09._09_Зв_язки_між_таблицями.ModelsConfig
{
    internal class FacultiesConfig : IEntityTypeConfiguration<Faculties>
    {
        public void Configure(EntityTypeBuilder<Faculties> builder)
        {
            builder.ToTable("faculties", t =>
            {
                t.HasCheckConstraint("CK_faculties_name_not_empty", "LEN(TRIM(faculty_name)) > 0");
            });
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id)
                .HasColumnName("faculty_id")
                .ValueGeneratedOnAdd();

            builder.Property(f => f.Name)
                .HasColumnName("faculty_name")
                .HasMaxLength(100)
                .IsRequired();
            builder.HasIndex(f => f.Name).IsUnique();

        }
    }
}