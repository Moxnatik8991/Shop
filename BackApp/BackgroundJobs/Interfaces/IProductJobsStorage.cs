namespace Shop.BackApp.BackgroundJobs.Interfaces
{
    public interface IProductJobsStorage
    {
        Task AddViews(Guid productId);
        Task IsUpdRating(Guid productId);

        Dictionary<Guid, ProductСhanges> GetProductСhanges();
        void DeleteProductСhanges(Guid key);
    }
}
