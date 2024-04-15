using Shop.BackApp.Domain.Entity;

namespace Shop.BackApp.Repository.Interfaces
{
    public interface ICommentRepository : IBaseRepository<Comment>
    {
        Task<IEnumerable<Comment>> GetCommentsByProductIdAsync(Guid productId);
    }
}
