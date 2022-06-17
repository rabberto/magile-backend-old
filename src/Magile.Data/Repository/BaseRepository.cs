using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magile.Data.Context;
using Magile.Domain.Entities;
using Magile.Domain.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Magile.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MagileDbContext _context;
        private DbSet<T> _database;

        public BaseRepository(MagileDbContext context)
        {
            _context = context;
            _database = _context.Set<T>();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var result = await _database.FirstOrDefaultAsync(x => x.Id.Equals(id));
                if (result == null)
                    return false;

                _database.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<T> InsertAsync(T entity)
        {
            try
            {
                await _database.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IList<T>> SelectAllAsync()
        {
            try
            {
                return await _database.AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> SelectAsync(Guid id)
        {
            try
            {
                var result = await _database.FirstOrDefaultAsync(x => x.Id.Equals(id));
                if (result == null)
                    return null;

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                var result = await _database.FirstOrDefaultAsync(x => x.Id.Equals(entity.Id));
                if (result == null)
                    return null;

                _context.Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}