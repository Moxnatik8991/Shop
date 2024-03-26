using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Middleware.Exceptions;
using Shop.BackApp.Models.RequestModels;
using Shop.BackApp.Repository.Interfaces;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();

            var categoryFiltering = categories.Where(_ => _.CategoryId == null);

            return categoryFiltering;
        }

        public async Task<Category> GetAsync(Guid id)
        {
            var category = await _categoryRepository.GetAsync(id);

            if (category == null)
            {
                throw new NotFoundException(nameof(Category));
            }

            return category;
        }

        public async Task AddAsync(CategoryRequestModel model)
        {
            var newCategory = new Category
            {   
                Id = Guid.NewGuid(),
                Name = model.Name,
                CategoryId = model.CategoryId,
                DataCreate = DateTime.UtcNow,
                DataUpdate = DateTime.UtcNow,
            };

            await _categoryRepository.AddAsync(newCategory);
        }

        public async Task UpdateAsync(Guid id, CategoryRequestModel model)
        {
            var category = await _categoryRepository.GetAsync(id);

            if (category == null)
            {
                throw new NotFoundException(nameof(Category));
            }

            category.Name = model.Name;
            category.CategoryId = model.CategoryId;
            category.DataUpdate = DateTime.UtcNow;

            await _categoryRepository.UpdateAsync(category);
        }

        public async Task DeleteAsync(Guid id)
        {
            var category = await _categoryRepository.GetAsync(id);

            if (category == null)
            {
                throw new NotFoundException(nameof(Category));
            }

            await _categoryRepository.DeleteAsync(id);
        }
    }
}
