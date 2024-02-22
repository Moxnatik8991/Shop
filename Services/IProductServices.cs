using Shop.Domain.Entity;
using Shop.Helpers.FilteringAndPagination;

namespace Shop.Services
{
    public interface IProductServices
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetWithFilteringAndPagination(SearchParams searchParam);
    }
}
