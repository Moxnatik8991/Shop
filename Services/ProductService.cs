using Shop.Abstractions;
using Shop.Domain.Entity;

namespace Shop.Services
{
    public class ProductService : IProductServices
    {
        private readonly IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();

            return products;
        }
    }
}
