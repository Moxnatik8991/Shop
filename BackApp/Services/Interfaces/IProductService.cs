using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Helpers.FilteringAndPagination;

namespace Shop.BackApp.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetWithFilteringAndPagination(SearchParams searchParam);
        Task<Product> GetAsync(Guid id);
    }
}
