using Magile.Data.Context;
using Magile.Data.Repository;
using Magile.Domain.Entities.Role;
using Microsoft.EntityFrameworkCore;

namespace Magile.Data.Implementation
{
    public class RoleImplementation : BaseRepository<RoleEntity>, IRoleRepository
    {
        private DbSet<RoleEntity> _dataset;

        public RoleImplementation(MagileDbContext context) : base(context)
            => _dataset = context.Set<RoleEntity>();
    }
}