using Magile.Domain.Entities.Cash;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magile.Data.Mapping.Cash
{
    public sealed class CashMap : IEntityTypeConfiguration<CashEntity>
    {
        public void Configure(EntityTypeBuilder<CashEntity> builder)
        {
            builder.ToTable("Cash")
                .HasKey(x => x.Id);

            builder.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(36);

            builder.Property(x => x.IssueDate)
                .IsRequired();

            builder.Property(x => x.DocumentNumber)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);

            builder.Property(x => x.Value)
                .IsRequired()
                .HasColumnType("DECIMAL")
                .HasMaxLength(18);

            builder.Property(x => x.Operation)
                .IsRequired()
                .HasColumnType("SMALLINT")
                .HasMaxLength(1);

            builder.Property(x => x.CategoryParentId)
                .IsRequired()
                .HasColumnType("VARCAHR")
                .HasMaxLength(36);

            builder.Property(x => x.CategoryId)
                .IsRequired()
                .HasColumnType("VARCAHR")
                .HasMaxLength(36);

            builder.Property(x => x.EvidenceCloudPath)
                .IsRequired()
                .HasColumnType("VARCAHR")
                .HasMaxLength(500);

            builder.Property(x => x.EvidenceName)
                .IsRequired()
                .HasColumnType("VARCAHR")
                .HasMaxLength(100);

            builder.Property(x => x.EvidenceName)
                .IsRequired()
                .HasColumnType("SMALLINT")
                .HasMaxLength(1);

            builder.Property(x => x.History)
               .IsRequired()
               .HasColumnType("VARCHAR")
               .HasMaxLength(200);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Cash);

            builder.HasOne(x => x.CategoryParent)
                .WithMany(x => x.Cash);

            builder.HasOne(x => x.Branch)
                .WithMany(x => x.Cash);
        }
    }
}
