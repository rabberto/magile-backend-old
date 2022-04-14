using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
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
            catch
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
            catch (System.Exception ex)
            {
                return null;
            }
        }

        public async Task<IList<T>> SelectAllAsync()
        {
            try
            {
                return await _database.AsNoTracking().ToListAsync();
            }
            catch (System.Exception ex)
            {
                return null;
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
            catch (System.Exception ex)
            {
                return null;
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
            catch
            {
                return null;
            }
        }
    }
}