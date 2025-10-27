using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelsCreating.Models;

namespace ModelsConfiguring.ModelsConfig
{
    internal class GroupsCuratorsConfig : IEntityTypeConfiguration<GroupsCurators>
    {
        public void Configure(EntityTypeBuilder<GroupsCurators> builder)
        {
            builder.ToTable("groups_curators");
            builder.HasKey(gc => gc.Id)
                   .HasName("PK_groups_curators");

            builder.Property(gc => gc.Id)
                   .HasColumnName("group_curator_id")
                   .ValueGeneratedOnAdd(); 

 
            builder.Property(gc => gc.CuratorId)
                   .HasColumnName("group_curator_curator_id")
                   .IsRequired();

            builder.Property(gc => gc.GroupId)
                   .HasColumnName("group_curator_group_id")
                   .IsRequired();

            //Foreign Keys

            //CuratorId
            builder.HasOne(gc => gc.CuratorNav) // один
                   .WithMany(c => c.GroupsCuratorsNav) //ко многим"
                   .HasForeignKey(gc => gc.CuratorId) // C# свойство
                   .HasConstraintName("FK_groups_curators_curator_id");

            //GroupId
            builder.HasOne(gc => gc.GroupNav) //один
                   .WithMany(g => g.GroupsCuratorsNav) //ко многим
                   .HasForeignKey(gc => gc.GroupId) // C# свойство
                   .HasConstraintName("FK_groups_curators_group_id");
        }
    }
}