using Shop.Domain.Entity;

namespace Shop.Services
{
    public interface IProductServices
    {
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
