using Magile.Domain.Entities;
using System.Threading.Tasks;

namespace Magile.Data.Repository
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> GetByEmailAsync(string email);
    }
}