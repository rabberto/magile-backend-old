using Magile.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magile.Data.Mapping
{
    public class BranchMap : IEntityTypeConfiguration<BranchEntity>
    {
        public void Configure(EntityTypeBuilder<BranchEntity> builder)
        {
            builder.ToTable("Branch")
                .HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Address)
                .IsRequired()
                .HasColumnName("Address")
                .HasColumnType("VARCHAR")
                .HasMaxLength(300);

            builder.Property(x => x.Phone)
                .IsRequired()
                .HasColumnName("Phone")
                .HasColumnType("VARCHAR")
                .HasMaxLength(300);

            builder.Property(x => x.ExternalId)
                .HasColumnName("ExternalId")
                .HasColumnType("VARCHAR")
                .HasMaxLength(15);

            builder.HasMany(x => x.Users)
                .WithOne(x => x.Branch);
        }
    }
}