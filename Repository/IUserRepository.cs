using Shop.Domain.Entity;

namespace Shop.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetUserByEmail(string email);
    }
}
