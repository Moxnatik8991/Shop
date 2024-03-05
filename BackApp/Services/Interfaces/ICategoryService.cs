using Shop.BackApp.Domain.Entity;

namespace Shop.BackApp.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }
}