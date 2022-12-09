using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magile.Data.Repository;
using Magile.Domain.Entities.Users;
using Magile.Domain.Interfaces;

namespace Magile.Service.Services
{
    public class UserTermService : IUserTermService
    {
        private IUserTermRepository _repository;

        public UserTermService(IUserTermRepository repository)
        {
            _repository = repository;
        }

        public Task<bool> Delete(Guid id)
            => _repository.DeleteAsync(id);

        public Task<UserTermEntity> Get(Guid id)
            => _repository.SelectAsync(id);

        public Task<IList<UserTermEntity>> GetAll()
            => _repository.SelectAllAsync();

        public Task<UserTermEntity> Post(UserTermEntity entity)
            => _repository.InsertAsync(entity);

        public Task<UserTermEntity> Put(UserTermEntity entity)
            => _repository.UpdateAsync(entity);

    }
}