using Magile.Domain.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magile.Data.Mapping.Categories
{
    public sealed class CategoryFinancialMap : IEntityTypeConfiguration<CategoryFinancialEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryFinancialEntity> builder)
        {
            builder.ToTable("Category")
                .HasKey("Id");

            builder.Property(x => x.LegalAccount)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(15);
        }
    }
}
