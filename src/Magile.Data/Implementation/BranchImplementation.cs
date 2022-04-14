using Magile.Data.Context;
using Magile.Data.Repository;
using Magile.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Magile.Data.Implementation
{
    public class BranchImplementation : BaseRepository<BranchEntity>, IBranchRepository
    {
        private DbSet<BranchEntity> _dataset;

        public BranchImplementation(MagileDbContext context) : base(context)
            => _dataset = context.Set<BranchEntity>();
    }
}