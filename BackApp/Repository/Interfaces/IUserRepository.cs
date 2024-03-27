using Shop.BackApp.Domain.Entity;

namespace Shop.BackApp.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetUserByEmail(string email);
    }
}
