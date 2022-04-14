using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magile.Domain.Entities;

namespace Magile.Data.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> SelectAsync(Guid id);
        Task<IList<T>> SelectAllAsync();
        Task<bool> DeleteAsync(Guid id);
    }
}