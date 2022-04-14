using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magile.Data.Repository;
using Magile.Domain.Entities;
using Magile.Domain.Interfaces;

namespace Magile.Service.Services
{
    public class BranchService : IBranchService
    {
        private IBranchRepository _repository;

        public BranchService(IBranchRepository repository)
            => _repository = repository;

        public async Task<bool> Delete(Guid id)
            => await _repository.DeleteAsync(id);

        public async Task<BranchEntity> Get(Guid id)
            => await _repository.SelectAsync(id);

        public async Task<IList<BranchEntity>> GetAll()
            => await _repository.SelectAllAsync();

        public Task<BranchEntity> Post(BranchEntity entity)
            => _repository.InsertAsync(entity);

        public Task<BranchEntity> Put(BranchEntity entity)
            => _repository.UpdateAsync(entity);
    }
}