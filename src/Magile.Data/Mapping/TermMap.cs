using Magile.Domain.Entities.Term;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magile.Data.Mapping
{
    public class TermMap : IEntityTypeConfiguration<TermEntity>
    {
        public void Configure(EntityTypeBuilder<TermEntity> builder)
        {
            builder.ToTable("Term")
                .HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(300);

            builder.Property(x => x.Base64)
                .IsRequired()
                .HasColumnType("LONG VARCHAR");

            builder.HasMany(x => x.Users)
                .WithMany(x => x.Terms);
        }
    }
}