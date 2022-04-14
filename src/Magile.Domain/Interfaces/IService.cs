using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magile.Domain.Entities;

namespace Magile.Domain.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        Task<T> Get(Guid id);
        Task<IList<T>> GetAll();
        Task<T> Post(T entity);
        Task<T> Put(T entity);
        Task<bool> Delete(Guid id);
    }
}