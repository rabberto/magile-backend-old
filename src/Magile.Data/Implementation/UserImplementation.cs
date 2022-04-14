using Magile.Data.Context;
using Magile.Data.Repository;
using Magile.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Magile.Data.Implementation
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataSet;

        public UserImplementation(MagileDbContext context) : base(context)
            => _dataSet = context.Set<UserEntity>();
    }
}