using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Repository.Interfaces;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.Services
{
    public class FileDetailsService : IFileDetailsService
    {
        private readonly IBaseRepository<FileDetails> _fileDetaisRepository;

        public FileDetailsService(IBaseRepository<FileDetails> fileDetaisRepository)
        {
            _fileDetaisRepository = fileDetaisRepository;
        }

        public async Task AddAsync(FileDetails model)
        {
            await _fileDetaisRepository.AddAsync(model);
        }
    }
}
