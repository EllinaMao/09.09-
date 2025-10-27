using ModelsCreating.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModelsConfiguring.ModelsConfig
{
    internal class LecturesConfig : IEntityTypeConfiguration<Lectures>
    {
        public void Configure(EntityTypeBuilder<Lectures> builder)
        {
            builder.ToTable("lectures", t =>
            {
                // Ограничение CHECK: "Не может быть больше текущей даты"
                // GETDATE() - это функция SQL Server для получения текущей даты.
                t.HasCheckConstraint("CK_lectures_date_not_future", "[lecture_date] <= GETDATE()");
            });

            // Первичный ключ (Id)
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Id)
                   .HasColumnName("lecture_id")
                   .ValueGeneratedOnAdd(); // Автоприращение

            // Дата (Date)
            builder.Property(l => l.Date)
                   .HasColumnName("lecture_date")
                   .HasColumnType("date") // Явно указываем тип 'date'
                   .IsRequired(); // Not Null

            // Внешний ключ для Дисциплины (SubjectId)
            builder.Property(l => l.SubjectId)
                   .HasColumnName("subject_id")
                   .IsRequired();

            // Внешний ключ для Преподавателя (TeacherId)
            builder.Property(l => l.TeacherId)
                   .HasColumnName("teacher_id")
                   .IsRequired();

            // --- Настройка внешних ключей (связей) ---
            // Связь Один (Subjects) ко Многим (Lectures)
            builder.HasOne(l => l.Subject) // У лекции один предмет
                   .WithMany(s => s.LecturesNav) // У предмета много лекций
                   .HasForeignKey(l => l.SubjectId)
                   .OnDelete(DeleteBehavior.Cascade); 

            // Связь Один (Teachers) ко Многим (Lectures)
            builder.HasOne(l => l.Teacher) // У лекции один преподаватель
                   .WithMany(t => t.LecturesNav) // У преподавателя много лекций
                   .HasForeignKey(l => l.TeacherId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}