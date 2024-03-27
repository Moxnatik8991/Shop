using Microsoft.EntityFrameworkCore;
using Shop.BackApp.Domain;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Repository.Interfaces;

namespace Shop.BackApp.Repository
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
