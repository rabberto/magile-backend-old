using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User")
                .HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Password)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(12);

            builder.Property(x => x.Key)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(36);

            builder.Property(x => x.BirthDate)
                .IsRequired();

            builder.Property(x => x.Phone)
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);

            builder.Property(x => x.ExternalId)
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);

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

            builder.Property(x => x.SupervisorId)
                .HasMaxLength(36);

            builder.Property(x => x.BranchId)
                .HasMaxLength(36);

            builder.HasOne(x => x.Branch)
                .WithMany(x => x.Users);

            builder.HasMany(x => x.Terms)
                .WithMany(t => t.Users);

            builder.HasMany(x => x.Roles)
                .WithMany(x => x.Users);
        }
    }
}