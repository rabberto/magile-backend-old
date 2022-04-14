using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magile.Data.Repository;
using Magile.Domain.Entities;
using Magile.Domain.Interfaces;

namespace Magile.Service.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public Task<bool> Delete(Guid id)
            => _repository.DeleteAsync(id);

        public Task<UserEntity> Get(Guid id)
            => _repository.SelectAsync(id);

        public Task<IList<UserEntity>> GetAll()
            => _repository.SelectAllAsync();

        public Task<UserEntity> Post(UserEntity entity)
            => _repository.InsertAsync(entity);

        public Task<UserEntity> Put(UserEntity entity)
            => _repository.UpdateAsync(entity);
    }
}