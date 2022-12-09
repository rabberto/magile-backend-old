using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magile.Data.Repository;
using Magile.Domain.Entities.Users;
using Magile.Domain.Interfaces;

namespace Magile.Service.Services
{
    public class UserRoleService : IUserRoleService
    {
        private IUserRoleRepository _repository;

        public UserRoleService(IUserRoleRepository repository)
        {
            _repository = repository;
        }

        public Task<bool> Delete(Guid id)
            => _repository.DeleteAsync(id);

        public Task<UserRoleEntity> Get(Guid id)
            => _repository.SelectAsync(id);

        public Task<IList<UserRoleEntity>> GetAll()
            => _repository.SelectAllAsync();

        public Task<UserRoleEntity> Post(UserRoleEntity entity)
            => _repository.InsertAsync(entity);

        public Task<UserRoleEntity> Put(UserRoleEntity entity)
            => _repository.UpdateAsync(entity);
    }
}