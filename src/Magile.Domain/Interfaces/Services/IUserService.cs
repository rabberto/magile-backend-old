using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magile.Domain.Entities;
using Magile.Domain.ViewModels.User;

namespace Magile.Domain.Interfaces
{
    public interface IUserService
    {
        Task<UserEntity> GetByIdAsync(Guid id);
        Task <IList<UserEntity>> GetAllAsync();
        Task<UserEntity> InsertAsync(UserInsertViewModel model);
        Task<UserEntity> UpdateAsync(UserUpdateViewModel model);
        Task DeleteAsync(Guid id);
        Task<UserEntity> InsertFinancialAsync(UserFinancialInsertViewModel model);
        Task<UserEntity> UpdateFinancialAsync(UserFinancialUpdateViewModel model);
        Task<UserEntity> GetByEmailAsync(string email);
    }
}