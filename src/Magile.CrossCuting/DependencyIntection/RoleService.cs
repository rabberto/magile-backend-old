using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magile.Data.Repository;
using Magile.Domain.Entities;
using Magile.Domain.Interfaces;

namespace Magile.CrossCuting.DependencyInjection
{
    internal class RoleService : IRoleService
    {
        private IRoleRepository _repository;

        public RoleService(IRoleRepository repository)
            => _repository = repository;

        public async Task<bool> Delete(Guid id)
            => await _repository.DeleteAsync(id);

        public async Task<RoleEntity> Get(Guid id)
            => await _repository.SelectAsync(id);

        public async Task<IList<RoleEntity>> GetAll()
            => await _repository.SelectAllAsync();

        public Task<RoleEntity> Post(RoleEntity entity)
            => _repository.InsertAsync(entity);

        public Task<RoleEntity> Put(RoleEntity entity)
            => _repository.UpdateAsync(entity);
    }
}