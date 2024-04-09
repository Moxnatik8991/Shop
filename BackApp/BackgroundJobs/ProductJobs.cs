using Shop.BackApp.BackgroundJobs.Interfaces;
using Shop.BackApp.Domain.Entity;
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
            var _productService = _serviceProvider.GetService<IProductService>();
            //var _commentService = _serviceProvider.GetService<ICommentService>();

            foreach (var item in _productСhanges)
            {
                var product = await _productService.GetAsync(item.Key);

                if (product == null) continue;

                if (item.Value.Views != uint.MinValue)
                    await UpdateProductViews(product, item.Value.Views);

                if (item.Value.IsRating)
                    await UpdateProductRating(product/*, _commentService*/);

                await _productService.SaveChangesAsync();


                _productJobsStorage.DeleteProductСhanges(item.Key);
            }


        }
        catch (Exception ex) { }
    }

    private async Task UpdateProductViews (Product product, uint views)
    {
        product.Views += views;
    }

    private async Task UpdateProductRating(Product product/*, ICommentService _commentService*/)
    {
        product.Rating = (decimal) product.Comments.Select(_ => _.Rating).ToArray().Average();
    }


}

public class ProductСhanges
{
    public uint Views { get; set; } = uint.MinValue;

    public bool IsRating {  get; set; } = false;
}

