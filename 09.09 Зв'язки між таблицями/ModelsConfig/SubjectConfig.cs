using _09._09_Зв_язки_між_таблицями.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _09._09_Зв_язки_між_таблицями.ModelsConfig
{
    internal class SubjectConfig : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
           builder.ToTable("subjects", t =>
           {
               t.HasCheckConstraint("CK_subjects_name_not_empty", "LEN(TRIM(subject_name)) > 0");
           });
              builder.HasKey(s => s.Id);
                builder.Property(s => s.Id)
                     .HasColumnName("subject_id")
                     .ValueGeneratedOnAdd();

                builder.Property(s => s.Name)
                        .HasColumnName("subject_name")
                        .IsRequired()
                        .HasMaxLength(100);
            
        }
    }
}