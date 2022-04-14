using System;
using System.Threading.Tasks;
using Magile.Data.Repository;
using Magile.Domain.Entities;
using Magile.Domain.Interfaces;

namespace Magile.Service.Services
{
    public class TermService : ITermService
    {
        private ITermRepository _repository;
        public TermService(ITermRepository repository)
        {
            _repository = repository;
        }
        public Task<bool> Delete(Guid id)
            => _repository.DeleteAsync(id);

        public Task<TermEntity> Get(Guid id)
            => _repository.SelectAsync(id);

        public Task<System.Collections.Generic.IList<TermEntity>> GetAll()
            => _repository.SelectAllAsync();

        public Task<TermEntity> Post(TermEntity entity)
            => _repository.InsertAsync(entity);

        public Task<TermEntity> Put(TermEntity entity)
            => _repository.UpdateAsync(entity);
    }
}