using Magile.Data.Context;
using Magile.Data.Repository;
using Magile.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Magile.Data.Implementation
{
    public class UserTermImplementation : BaseRepository<UserTermEntity>, IUserTermRepository
    {
        private DbSet<UserTermEntity> _dataset;
        public UserTermImplementation(MagileDbContext context) : base(context)
            => _dataset = context.Set<UserTermEntity>();
    }
}