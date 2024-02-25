using Microsoft.EntityFrameworkCore;
using Shop.Domain;
using Shop.Domain.Entity;

namespace Shop.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DataContext contex) : base(contex) { }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _dataContext.Set<User>().FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
