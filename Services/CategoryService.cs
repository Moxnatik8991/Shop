using Shop.Domain.Entity;
using Shop.Repository;
using Shop.Services.Interfaces;

namespace Shop.Services
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
