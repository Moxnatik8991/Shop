using Microsoft.EntityFrameworkCore;
using Shop.BackApp.Domain;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Repository.Interfaces;

namespace Shop.BackApp.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext contex) : base(contex) { }

        public override async Task<Product?> GetAsync(Guid id)
        {
            return await _dataContext.Products.FirstOrDefaultAsync(_ => _.Id == id);
        }
    }
}
