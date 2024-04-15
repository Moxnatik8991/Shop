using Shop.BackApp.BackgroundJobs.Interfaces;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Middleware.Exceptions;
using Shop.BackApp.Models.RequestModels;
using Shop.BackApp.Repository.Interfaces;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IProductRepository _productRepository;

        private readonly IProductJobsStorage _productJobsStorage;
        public CommentService(ICommentRepository commentRepository, IProductJobsStorage productJobsStorage, IProductRepository productRepository)
        {
            _commentRepository = commentRepository;
            _productJobsStorage = productJobsStorage;
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<Comment>> GetAllAsync()
        {
           return await  _commentRepository.GetAllAsync();
        }

        public async Task<Comment?> GetAsync(Guid id)
        {
            return await _commentRepository.GetAsync(id);
        }

        public async Task AddAsync(CommentRequestModel model)
        {
            var product = await _productRepository.GetAsync(model.ProductId);

            if (product == null)
            {
                throw new NotFoundException(nameof(Product));
            }

            var newComment = new Comment
            {
                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                ProductId = model.ProductId,
                Rating = model.Rating,
                Text = model.Text,
                DataCreate = DateTime.UtcNow,
                DataUpdate = DateTime.UtcNow,
            };

            await _commentRepository.AddAsync(newComment);
            await _productJobsStorage.IsUpdRating(model.ProductId);
        }

        public async Task DeleteAsync(Guid id)
        {
             await _commentRepository.DeleteAsync(id);
        }

    }
}
