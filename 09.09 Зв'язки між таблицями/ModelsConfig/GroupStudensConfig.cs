using Microsoft.EntityFrameworkCore;
using ModelsCreating.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModelsConfiguring.ModelsConfig
{
    internal class GroupStudensConfig : IEntityTypeConfiguration<GroupStudents>
    {
        public void Configure(EntityTypeBuilder<GroupStudents> builder)
        {
            builder.ToTable("group_students");

            //Первичный ключ (Primary Key)
            builder.HasKey(gs => gs.Id)
                   .HasName("PK_group_students");

            builder.Property(gs => gs.Id)
                   .HasColumnName("group_student_id")
                   .ValueGeneratedOnAdd(); // Автоприращение


            // Столбец для GroupId
            builder.Property(gs => gs.GroupId)
                   .HasColumnName("group_student_group_id") 
                   .IsRequired();

            // Столбец для StudentId
            builder.Property(gs => gs.StudentId)
                   .HasColumnName("group_student_student_id") 
                   .IsRequired();

            // Внешние ключи (Foreign Keys)
            // Внешний ключ для Группы (GroupId)
            builder.HasOne(gs => gs.GroupNav) // один
                   .WithMany(g => g.GroupsStudentsNav) // ко многим
                   .HasForeignKey(gs => gs.GroupId) // C# свойство
                   .HasConstraintName("FK_group_students_groups_group_id");

            // Внешний ключ для Студента (StudentId)
            builder.HasOne(gs => gs.StudentNav) // один
                   .WithMany(s => s.GroupsStudentsNav) // ко многим
                   .HasForeignKey(gs => gs.StudentId) // C# свойство
                   .HasConstraintName("FK_group_students_students_student_id");
        }
    }
}