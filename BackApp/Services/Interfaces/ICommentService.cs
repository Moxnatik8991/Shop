using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Models.RequestModels;

namespace Shop.BackApp.Services.Interfaces
{
    public interface ICommentService : IBaseService<Comment>
    {
        Task<IEnumerable<Comment>> GetCommentsByProductIdAsync(Guid productId);

        Task AddAsync(CommentRequestModel model);
        Task UpdateAsync(Guid id, CommentRequestModel model);
    }
}
