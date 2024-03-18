using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Models.RequestModels;

namespace Shop.BackApp.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetAsync(Guid id);
        Task AddAsync(CategoryRequestModel model);
        Task UpdateAsync(Guid id, CategoryRequestModel model);
        Task DeleteAsync(Guid id);
    }
}