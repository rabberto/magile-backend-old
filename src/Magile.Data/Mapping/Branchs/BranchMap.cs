using Magile.Domain.Entities.Branch;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magile.Data.Mapping.Branchs
{
    public class BranchMap : IEntityTypeConfiguration<BranchEntity>
    {
        public void Configure(EntityTypeBuilder<BranchEntity> builder)
        {
            builder.ToTable("Branch")
                .HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Address)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(300);

            builder.Property(x => x.Phone)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);

            builder.Property(x => x.ExternalId)
                .HasMaxLength(15);

            builder.HasMany(x => x.Users)
                .WithOne(x => x.Branch);

            builder.HasMany(x => x.Departaments)
                .WithOne(x => x.Branch);
        }
    }
}