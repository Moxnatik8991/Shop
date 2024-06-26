﻿using Microsoft.EntityFrameworkCore;
using Shop.BackApp.Domain;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Repository.Interfaces;

namespace Shop.BackApp.Repository;
public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(DataContext context) : base(context) {}

    public override async Task<IEnumerable<Category>> GetAllAsync()
    {  
        return await _dataContext.Categories.Include(_ => _.Categories).Include(_ => _.File).ToListAsync();
    }

    public override async Task<Category?> GetAsync(Guid id)
    {
        return await _dataContext.Categories.Include(_ => _.Categories).Include(_ => _.File).FirstOrDefaultAsync(_ => _.Id == id);
    }
}
 