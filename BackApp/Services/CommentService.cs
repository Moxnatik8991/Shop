using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Models.RequestModels;
using Shop.BackApp.Repository;
using Shop.BackApp.Repository.Interfaces;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
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
        }

        public async Task DeleteAsync(Guid id)
        {
             await _commentRepository.DeleteAsync(id);
        }

    }
}
