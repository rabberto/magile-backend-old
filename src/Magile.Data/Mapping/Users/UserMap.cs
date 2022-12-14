using Magile.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magile.Data.Mapping.Users
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

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Password)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(12);

            builder.Property(x => x.Document)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);

            builder.Property(x => x.KeyValidation)
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

            builder.Property(x => x.SupervisorId)
                .HasColumnType("VARCHAR")
                .HasMaxLength(36);

            builder.Property(x => x.Branch)
                .HasColumnType("VARCHAR")
                .HasMaxLength(36);

            builder.HasOne(x => x.Supervisor)
                .WithMany(x => x.Users);

            builder.HasOne(x => x.Branch)
                .WithMany(x => x.Users);

            builder.HasMany(x => x.Terms)
                .WithMany(t => t.Users);

            builder.HasMany(x => x.Roles)
                .WithMany(x => x.Users);
        }
    }
}