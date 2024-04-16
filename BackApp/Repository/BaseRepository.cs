using Microsoft.EntityFrameworkCore;
using Shop.BackApp.Domain;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Helpers.FilteringAndPagination;
using Shop.BackApp.Repository.Interfaces;
using System.Linq.Expressions;

namespace Shop.BackApp.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly DataContext _dataContext;
        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dataContext.Set<T>().ToListAsync();
        }

        public virtual async Task<T?> GetAsync(Guid id)
        {
            return await _dataContext.Set<T>().FirstOrDefaultAsync(_ => _.Id == id);
        }
        public virtual async Task AddAsync(T entity)
        {
            await _dataContext.AddAsync(entity);

            await _dataContext.SaveChangesAsync();
        }
        public virtual async Task UpdateAsync(T entity)
        {
            await _dataContext.SaveChangesAsync();


            //var entity2 = await _dataContext.Set<T>().FirstOrDefaultAsync(_ => _.Id == entity.Id);

            //if (entity2 != null)
            //{
            //    entity = entity2;
            //    await _dataContext.SaveChangesAsync();
            //}
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            var entity = await _dataContext.Set<T>().FirstOrDefaultAsync(_ => _.Id == id);

            if (entity != null)
            {
                _dataContext.Set<T>().Remove(entity);
                await _dataContext.SaveChangesAsync();
            }
        }

        public virtual IQueryable<T> CustomQuery(Expression<Func<T, bool>> filters)
        {
            return _dataContext.Set<T>().AsQueryable().CustomQuery(filters);
        }
    }
}
