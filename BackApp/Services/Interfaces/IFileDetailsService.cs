using Shop.BackApp.Domain.Entity;

namespace Shop.BackApp.Services.Interfaces
{
    public interface IFileDetailsService
    {
        Task AddAsync(FileDetails model);
    }
}
