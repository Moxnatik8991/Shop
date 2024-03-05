using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Repository;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<Category> _categoryRepository;
        public CategoryService(IBaseRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var products = await _categoryRepository.GetAllAsync();

            return products;
        }
    }
}
