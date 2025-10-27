using _09._09_Зв_язки_між_таблицями.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _09._09_Зв_язки_між_таблицями.ModelsConfig
{
    internal class GroupsConfig : IEntityTypeConfiguration<Groups>
    {
        public void Configure(EntityTypeBuilder<Groups> builder)
        {
            builder.ToTable("groups", t =>
            {
                t.HasCheckConstraint("CK_groups_name_not_empty", "LEN(TRIM(group_name)) > 0");
                t.HasCheckConstraint("CK_groups_year_range", "[group_year] BETWEEN 1 AND 5");
            });
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id)
                .HasColumnName("group_id")
                .ValueGeneratedOnAdd();

            builder.Property(g => g.Name)
                .HasColumnName("group_name")
                .HasMaxLength(10)
                .IsRequired();
            builder.HasIndex(g => g.Name)
                .IsUnique();

            builder.Property(g => g.Year)
                .HasColumnName("group_year")
                .IsRequired();

            builder.Property(g => g.DepartmentId)
                .HasColumnName("department_id")
                .IsRequired();

            builder.HasOne(g => g.Department)
                    .WithMany(d => d.Groups)
                    .HasForeignKey(g => g.DepartmentId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}