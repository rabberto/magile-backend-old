using Magile.Data.Context;
using Magile.Data.Repository;
using Magile.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Magile.Data.Implementation
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataSet;

        public UserImplementation(MagileDbContext context) : base(context)
            => _dataSet = context.Set<UserEntity>();

        public async Task<UserEntity> GetByEmailAsync(string email)
            => await _dataSet.FirstOrDefaultAsync(x => x.Email == email);
    }
}