using Magile.Domain.Entities.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magile.Data.Mapping.Companies
{
    //public sealed class CompanyMap : IEntityTypeConfiguration<CompanyEntity>
    //{
    //    public void Configure(EntityTypeBuilder<CompanyEntity> builder)
    //    {
    //        builder.ToTable("Company")
    //            .HasKey("Id");

    //        builder.Property(x => x.Name)
    //            .IsRequired()
    //            .HasColumnType("VARCHAR")
    //            .HasMaxLength(100);

    //        builder.Property(x => x.SocialName)
    //            .IsRequired()
    //            .HasColumnType("VARCHAR")
    //            .HasMaxLength(100);

    //        builder.Property(x => x.Document)
    //            .IsRequired()
    //            .HasColumnType("VARCHAR")
    //            .HasMaxLength(20);

    //        builder.Property(x => x.Password)
    //            .IsRequired()
    //            .HasColumnType("VARCHAR")
    //            .HasMaxLength(12);
    //    }
    //}
}
