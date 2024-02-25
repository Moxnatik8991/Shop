using Shop.Domain.Entity;

namespace Shop.Services.Interfaces
{
    public interface ICategoryServices
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }
}