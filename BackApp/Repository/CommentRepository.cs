using Microsoft.EntityFrameworkCore;
using Shop.BackApp.Domain;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Middleware.Exceptions;
using Shop.BackApp.Repository.Interfaces;

namespace Shop.BackApp.Repository
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(DataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Comment>> GetCommentsByProductIdAsync(Guid productId)
        {
            return await _dataContext.Comments.Where(_ => _.ProductId == productId).OrderBy(_ => _.DataCreate).ToListAsync();
        }
    }
}
