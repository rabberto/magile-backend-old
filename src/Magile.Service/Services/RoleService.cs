using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magile.Data.Repository;
using Magile.Domain.Entities.Role;
using Magile.Domain.Interfaces;

namespace Magile.Service.Services
{
    public class RoleService : IRoleService
    {
        private IRoleRepository _repository;

        public RoleService(IRoleRepository repository)
        {
            _repository = repository;
        }

        public Task<bool> Delete(Guid id)
            => _repository.DeleteAsync(id);

        public Task<RoleEntity> Get(Guid id)
            => _repository.SelectAsync(id);

        public Task<IList<RoleEntity>> GetAll()
            => _repository.SelectAllAsync();

        public Task<RoleEntity> Post(RoleEntity entity)
            => _repository.InsertAsync(entity);

        public Task<RoleEntity> Put(RoleEntity entity)
            => _repository.UpdateAsync(entity);
    }
}