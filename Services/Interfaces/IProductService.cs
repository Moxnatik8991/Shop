using Shop.Domain.Entity;
using Shop.Helpers.FilteringAndPagination;

namespace Shop.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetWithFilteringAndPagination(SearchParams searchParam);
        Task<Product> GetAsync(Guid id);
    }
}
