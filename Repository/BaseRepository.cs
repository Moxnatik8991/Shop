using Microsoft.EntityFrameworkCore;
using Shop.Domain;
using Shop.Domain.Entity;
using Shop.Helpers.FilteringAndPagination;
using System.Linq.Expressions;

namespace Shop.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly DataContext _dataContext;
        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dataContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(Guid id)
        {
            return await _dataContext.Set<T>().FirstOrDefaultAsync(_ => _.Id == id);
        }
        public async Task AddAsync(T entity)
        {
            await _dataContext.AddAsync(entity);

            await _dataContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(T entity)
        {
            var entity2 = await _dataContext.Set<T>().FirstOrDefaultAsync(_ => _.Id == entity.Id);

            if (entity2 != null)
            {
                entity = entity2;
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dataContext.Set<T>().FirstOrDefaultAsync(_ => _.Id == id);

            if (entity != null)
            {
                _dataContext.Set<T>().Remove(entity);
                await _dataContext.SaveChangesAsync();
            }
        }

        public IQueryable<T> CustomQuery(Expression<Func<T, bool>> filters)
        {
            return _dataContext.Set<T>().AsQueryable().CustomQuery(filters);
        }
    }
}
