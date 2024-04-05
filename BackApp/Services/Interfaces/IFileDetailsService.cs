using Shop.BackApp.Domain.Entity;

namespace Shop.BackApp.Services.Interfaces
{
    public interface IFileDetailsService<T>
    {
         Task<T> AddAsync(IFormFile uploadedFile);
    }
}
