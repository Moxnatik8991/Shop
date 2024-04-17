using Shop.BackApp.BackgroundJobs.Interfaces;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Helpers.FilteringAndPagination;
using Shop.BackApp.Middleware.Exceptions;
using Shop.BackApp.Models.RequestModels;
using Shop.BackApp.Repository;
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
           return await _commentRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Comment>> GetCommentsByProductIdAsync(Guid productId, PaginationParams paginationParams, HttpResponse httpResponse)
        {
            var query = _commentRepository.CustomQuery(null);

            query = query.Where(x => x.ProductId == productId);

            var count = query.Count();

            var filteredData = query.CustomPagination(paginationParams.PageNumber, paginationParams.PageSize).OrderBy(_ => _.DataCreate).ToList();

            var pagedList = new PagedList<Comment>(filteredData, count, paginationParams.PageNumber, paginationParams.PageSize);

            if (pagedList != null)
            {
                httpResponse.AddPaginationHeader(pagedList.MetaData);
            }

            return filteredData;
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

        public async Task UpdateAsync(Guid id, CommentRequestModel model)
        {
            var comment = await _commentRepository.GetAsync(id);

            if (comment == null)
            {
                throw new NotFoundException(nameof(Comment));
            }

            comment.FirstName = model.FirstName;
            comment.Rating = model.Rating;
            comment.DataUpdate = DateTime.UtcNow;

            await _commentRepository.UpdateAsync(comment);
            await _productJobsStorage.IsUpdRating(comment.ProductId);
        }

        public async Task DeleteAsync(Guid id)
        {
            var comment = await _commentRepository.GetAsync(id);

            if (comment == null)
            {
                throw new NotFoundException(nameof(Comment));
            }

            await _commentRepository.DeleteAsync(id);
            await _productJobsStorage.IsUpdRating(comment.ProductId);
        }
    }
}
