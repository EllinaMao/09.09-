using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _09._09_Зв_язки_між_таблицями.ModelsConfig
{
    internal class CuratorsConfig : IEntityTypeConfiguration<Curators>
    {
        public void Configure(EntityTypeBuilder<Curators> builder)
        {
            builder.ToTable("curators", t =>
            {
                t.HasCheckConstraint("CK_curators_name_not_empty", "LEN(TRIM(curators_name)) > 0");
                t.HasCheckConstraint("CK_curators_surname_not_empty", "LEN(TRIM(curators_surname)) > 0");
            });

            //to do не забыть прописать автоприращение, но оно и так есть
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("curators_id")
                   .IsRequired();

            builder.Property(c => c.Name)
                     .HasColumnName("curators_name")
                     .HasMaxLength(int.MaxValue)
                     .IsRequired();

            builder.Property(c => c.Surname)
                     .HasColumnName("curators_surname")
                     .HasMaxLength(int.MaxValue)
                     .IsRequired();

        }
    }
}