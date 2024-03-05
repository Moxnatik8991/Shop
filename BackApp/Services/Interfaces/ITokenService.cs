using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Models;

namespace Shop.BackApp.Services.Interfaces
{
    public interface ITokenService
    {
        Task<TokenModel> CreateToken(User user);
    }
}
