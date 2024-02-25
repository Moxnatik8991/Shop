using Shop.Abstractions;
using Shop.Domain.Entity;
using Shop.Services.Interfaces;

namespace Shop.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly IRepository<Category> _categoryRepository;
        public CategoryServices(IRepository<Category> categoryRepository)
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
