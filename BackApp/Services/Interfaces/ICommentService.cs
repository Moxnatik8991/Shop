using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Helpers.FilteringAndPagination;
using Shop.BackApp.Models.RequestModels;

namespace Shop.BackApp.Services.Interfaces
{
    public interface ICommentService : IBaseService<Comment>
    {
        Task<IEnumerable<Comment>> GetCommentsByProductIdAsync(Guid productId, PaginationParams paginationParams, HttpResponse httpResponse);

        Task AddAsync(CommentRequestModel model);
        Task UpdateAsync(Guid id, CommentRequestModel model);
    }
}
