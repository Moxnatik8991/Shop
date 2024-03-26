using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Models.RequestModels;

namespace Shop.BackApp.Services.Interfaces
{
    public interface ICommentService : IBaseService<Comment>
    {
        Task AddAsync(CommentRequestModel model);
    }
}
