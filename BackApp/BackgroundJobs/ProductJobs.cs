using Shop.BackApp.BackgroundJobs.Interfaces;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Repository.Interfaces;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.BackgroundJobs;
public class ProductJobs : IProductJobs
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IProductJobsStorage _productJobsStorage;
    private readonly Dictionary<Guid, ProductСhanges> _productСhanges;
    public ProductJobs(IServiceProvider serviceProvider, IProductJobsStorage productJobsStorage)
    {
        _serviceProvider = serviceProvider;
        _productJobsStorage = productJobsStorage;

        _productСhanges = _productJobsStorage.GetProductСhanges();
    }

    public async Task UpdatingProducts()
    {
        if (_productСhanges == null || _productСhanges.Count() < 1)
            return;

        try
        {
            var _productRepository = _serviceProvider.GetService<IProductRepository>();
            var _commentRepository = _serviceProvider.GetService<ICommentRepository>();

            foreach (var item in _productСhanges)
            {
                var product = await _productRepository.GetAsync(item.Key);

                if (product == null) continue;

                if (item.Value.CountViews != uint.MinValue)
                    await UpdateProductViews(product, item.Value.CountViews);

                if (item.Value.IsUpdateRating)
                {
                    var comments = await _commentRepository.GetCommentsByProductIdAsync(product.Id);

                    await UpdateProductRating(product, comments);
                }

                await _productRepository.UpdateAsync(product);


                _productJobsStorage.DeleteProductСhanges(item.Key);
            }


        }
        catch (Exception ex) { }
    }

    private async Task UpdateProductViews (Product product, uint views)
    {
        product.CountViews += views;
    }

    private async Task UpdateProductRating(Product product, IEnumerable<Comment>? comments)
    {
        if (comments != null)
        {

            product.Rating = (decimal)comments.Select(_ => _.Rating).ToArray().Average();
            product.CountComments = (uint)comments.Count();
        }
        else
        {
            product.Rating = 0;
            product.CountComments = 0;
        }
    }
}

public class ProductСhanges
{
    public uint CountViews { get; set; } = uint.MinValue;

    public bool IsUpdateRating {  get; set; } = false;
}

