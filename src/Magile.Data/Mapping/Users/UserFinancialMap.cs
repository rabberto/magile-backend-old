using Magile.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magile.Data.Mapping.Users
{
    public sealed class UserFinancialMap : IEntityTypeConfiguration<UserFinancialEntity>
    {
        public void Configure(EntityTypeBuilder<UserFinancialEntity> builder)
        {
            builder.ToTable("User")
                .HasKey(x => x.Id);

            builder.Property(x => x.CardNumber)
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);

            builder.Property(x => x.CardLimit)
                .HasColumnType("DECIMAL")
                .HasMaxLength(18);

            builder.Property(x => x.StatusCard)
                .HasColumnType("SMALLINT")
                .HasMaxLength(1);

            builder.Property(x => x.CostCenter)
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);

            builder.Property(x => x.CashAccount)
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
        }
    }
}
