using Magile.Domain.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magile.Data.Mapping.Categories
{
    public sealed class CategoryMap : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.ToTable("Category")
                .HasKey("Id");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(200);

            builder.Property(x => x.ParentId)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(36);

            builder.Property(x => x.Type)
                .IsRequired()
                .HasColumnType("SMALLINT")
                .HasMaxLength(1);

            builder.HasMany(x => x.Cash)
                .WithOne(x => x.Category);

            builder.HasMany(x => x.Cash)
                .WithOne(x => x.CategoryParent);
        }
    }
}
