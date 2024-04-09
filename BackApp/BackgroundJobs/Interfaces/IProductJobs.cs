namespace Shop.BackApp.BackgroundJobs.Interfaces
{
    public interface IProductJobs
    {
        Task AddViews(Guid productId);

        Task UpdatingProducts();
    }
}
