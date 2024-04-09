using Shop.BackApp.BackgroundJobs.Interfaces;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.BackgroundJobs;
public class ProductJobs : IProductJobs
{
    private readonly Dictionary<Guid, ProductСhanges> _productСhanges;

    private readonly IServiceProvider _serviceProvider;
    public ProductJobs(IServiceProvider serviceProvider)
    {
        if (_productСhanges == null)
            _productСhanges = new();

        _serviceProvider = serviceProvider;
    }

    public async Task UpdatingProducts()
    {
        if (_productСhanges == null && _productСhanges.Count() < 1)
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

    public async Task AddViews(Guid productId)
    {
        _productСhanges.TryGetValue(productId, out var productСhanges);

        if (productСhanges == null)
        {
            _productСhanges.Add(productId, new ProductСhanges() { Views = 1});
        }
        else
        {
            productСhanges.Views += 1;
            _productСhanges[productId] = productСhanges;
        }
    }
}

public class ProductСhanges
{
    public uint Views { get; set; } = uint.MinValue;

    public bool IsRating {  get; set; } = false;
}

