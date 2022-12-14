using Magile.Domain.Entities.Departament;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magile.Data.Mapping.Departaments
{
    public sealed class DepartamentMap : IEntityTypeConfiguration<DepartamentEntity>
    {
        public void Configure(EntityTypeBuilder<DepartamentEntity> builder)
        {
            builder.ToTable("Departament")
                .HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(36);

            builder.HasOne(x => x.Branch)
                .WithMany(x => x.Departaments);
        }
    }
}
