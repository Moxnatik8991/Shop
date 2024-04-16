using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Helpers.FilteringAndPagination;
using Shop.BackApp.Models.RequestModels;

namespace Shop.BackApp.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetWithFilteringAndPagination(SearchParams searchParam, HttpResponse httpResponse);
        Task<Product> GetAsync(Guid id, bool isViews = false);

        //Task UpdateAsync(Guid id, ProductRequestModel model);

        Task SaveChangesAsync();
    }
}
