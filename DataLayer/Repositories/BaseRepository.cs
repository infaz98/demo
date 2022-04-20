using ApplicationLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected DataContext _dataContext;

        public BaseRepository(DataContext dbContext)
        {
            _dataContext = dbContext;
        }

        public async Task<T> GetByIdAsync<TId>(TId id)
        {
            return await _dataContext.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> ListAllAsync()
        {
            return await _dataContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            _dataContext.Set<T>().Add(entity);
            await _dataContext.SaveChangesAsync();

            return entity;
        }

        public async Task<int> DeleteAsync(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
            return await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dataContext.Entry(entity).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();
        }
    }
}