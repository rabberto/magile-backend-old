using Magile.Data.Context;
using Magile.Data.Repository;
using Magile.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Magile.Data.Implementation
{
    public class TermImplementation : BaseRepository<TermEntity>, ITermRepository
    {
        private DbSet<TermEntity> _dataset;

        public TermImplementation(MagileDbContext context) : base(context)
            => _dataset = context.Set<TermEntity>();
    }
}