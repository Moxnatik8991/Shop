using Shop.BackApp.Domain;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Middleware.Exceptions;
using Shop.BackApp.Repository.Interfaces;

namespace Shop.BackApp.Repository
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        private readonly IProductRepository _productRepository;
        public CommentRepository(DataContext context, IProductRepository productRepository) : base(context)
        {
            _productRepository = productRepository;
        }

        public override async Task AddAsync(Comment entity)
        {
            var product = await _productRepository.GetAsync(entity.ProductId);

            if (product == null)
            {
                throw new NotFoundException(nameof(Product));
            }

            await base.AddAsync(entity);
        }
    }
}
