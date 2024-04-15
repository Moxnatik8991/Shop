using Shop.BackApp.BackgroundJobs.Interfaces;

namespace Shop.BackApp.BackgroundJobs;
public class ProductJobsStorage : IProductJobsStorage 
{
    private readonly Dictionary<Guid, ProductСhanges> _productСhanges = new();

    public ProductJobsStorage()
    {
        
    }

    public async Task AddViews(Guid productId)
    {
        _productСhanges.TryGetValue(productId, out var productСhanges);

        if (productСhanges == null)
        {
            _productСhanges.Add(productId, new ProductСhanges() { CountViews = 1 });
        }
        else
        {
            productСhanges.CountViews += 1;
            _productСhanges[productId] = productСhanges;
        }
    }

    public async Task IsUpdRating(Guid productId)
    {
        _productСhanges.TryGetValue(productId, out var productСhanges);

        if (productСhanges == null)
        {
            _productСhanges.Add(productId, new ProductСhanges() { IsUpdateRating = true });
        }
        else
        {
            productСhanges.IsUpdateRating = true;
            _productСhanges[productId] = productСhanges;
        }
    }

    public void DeleteProductСhanges(Guid key)
    {
        _productСhanges.Remove(key);
    }

    public Dictionary<Guid, ProductСhanges> GetProductСhanges()
    {
        return _productСhanges;
    }
}

