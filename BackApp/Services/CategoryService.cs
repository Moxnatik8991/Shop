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
        private readonly IFileDetailsService<CategoryFileDetails> _fileDetailsService;
        public CategoryService(ICategoryRepository categoryRepository, IFileDetailsService<CategoryFileDetails> fileDetailsService)
        {
            _categoryRepository = categoryRepository;
            _fileDetailsService = fileDetailsService;
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
                Name = model.Name,
                CategoryId = model.CategoryId,
                DataCreate = DateTime.UtcNow,
                DataUpdate = DateTime.UtcNow,
            };

            if (model.File != null)
            {
                var fileDetailse = await _fileDetailsService.AddAsync(model.File);

                newCategory.File = fileDetailse;
            }

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

            if (model.File != null)
            {
                var newFile = await _fileDetailsService.AddAsync(model.File);

                if (category.File != null)
                    category.File.Update(newFile);
                else
                    category.File = newFile;
            }

            await _categoryRepository.UpdateAsync(category);
        }

        public async Task DeleteAsync(Guid id)
        {
            var category = await _categoryRepository.GetAsync(id);

            if (category == null)
            {
                throw new NotFoundException(nameof(Category));
            }

            if(category.Categories != null && category.Categories.Count() > 0)
            {
                throw new CustomException("Remove child categories first!");
            }

            await _categoryRepository.DeleteAsync(id);
        }
    }
}
