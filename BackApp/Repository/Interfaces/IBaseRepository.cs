﻿using Shop.BackApp.Domain.Entity;
using System.Linq.Expressions;

namespace Shop.BackApp.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetAsync(Guid id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(Guid id);


        IQueryable<T> CustomQuery(Expression<Func<T, bool>> filters);
    }
}
