using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class UserTermMap : IEntityTypeConfiguration<UserTermEntity>
    {
        public void Configure(EntityTypeBuilder<UserTermEntity> builder)
        {
            builder.ToTable("UserTerm");
            builder.HasKey(x => x.TermId);
            builder.HasKey(x => x.UserId);
        }
    }
}