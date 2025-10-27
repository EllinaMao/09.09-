using Microsoft.EntityFrameworkCore;
using ModelsCreating.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModelsConfiguring.ModelsConfig
{
    internal class GroupLecturesConfig : IEntityTypeConfiguration<GroupLectures>
    {
        public void Configure(EntityTypeBuilder<GroupLectures> builder)
        {
            builder.ToTable("group_lectures");
            //Первичный ключ
            builder.HasKey(gl => gl.Id)
                   .HasName("PK_group_lectures");
            builder.Property(gl => gl.Id)
                   .HasColumnName("group_lectures_id")
                   .ValueGeneratedOnAdd(); // Автоприращение

            //Внешний ключ
            builder.Property(gl => gl.GroupId)
                   .HasColumnName("group_lectures_group_id")
                   .IsRequired(); 

            //Внешний ключ
            builder.Property(gl => gl.LectureId)
                   .HasColumnName("group_lectures_lecture_id")
                   .IsRequired(); 

            //Внешние ключи
            //Groups
            builder.HasOne(gl => gl.GroupNav) // Навигационное свойство в GroupLectures
                   .WithMany(g => g.GroupsLecturesNav) 
                   .HasForeignKey(gl => gl.GroupId) 
                   .HasConstraintName("FK_group_lectures_groups_group_id");

            //Lectures
            builder.HasOne(gl => gl.LectureNav) // Навигационное свойство в GroupLectures
                   .WithMany(l => l.GroupsLecturesNav) 
                   .HasForeignKey(gl => gl.LectureId) 
                   .HasConstraintName("FK_group_lectures_lectures_lecture_id");
        }
    }
}