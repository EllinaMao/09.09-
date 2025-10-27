using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelsCreating.Models;
namespace ModelsConfiguring.ModelsConfig

{
    internal class DepartmentsConfig : IEntityTypeConfiguration<Departments>
    {
        public void Configure(EntityTypeBuilder<Departments> builder)
        {
            builder.ToTable("departments", t =>
            {
                t.HasCheckConstraint("CK_department_building_range", "[department_building] >= 1 AND [department_building] <= 5");
                t.HasCheckConstraint("CK_department_financing_positive", "[department_financing] >= 0");
                t.HasCheckConstraint("CK_department_name_not_empty", "LEN(TRIM(department_name)) > 0");
            });


            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id)
                .HasColumnName("department_id")
                .ValueGeneratedOnAdd();


            builder.Property(d => d.Building)
                .HasColumnName("department_building")
                .IsRequired();//!null


            builder.Property(d => d.Financing)
                .HasColumnName("department_financing")
                .HasColumnType("money")
                .HasDefaultValue(0)
                .IsRequired();
            
            
            builder.Property(d => d.Name)
                .HasColumnName("department_name")
                .HasMaxLength(100)
                .IsRequired();
            builder.HasIndex(d => d.Name).IsUnique();
           

            builder.Property(d => d.FacultyId)
                .HasColumnName("faculty_id")
                .IsRequired();

            builder.HasOne(d => d.FacultyNav)
                   .WithMany(f => f.DepartmentsNav)
                   .HasForeignKey(d => d.FacultyId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}