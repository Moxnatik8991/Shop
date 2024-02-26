using Shop.Domain.Entity;
using Shop.Models;

namespace Shop.Services.Interfaces
{
    public interface ITokenService
    {
        Task<TokenModel> CreateToken(User user);
    }
}
