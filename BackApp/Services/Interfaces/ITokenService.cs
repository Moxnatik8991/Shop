using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Models;
using Shop.BackApp.Models.RequestModels;

namespace Shop.BackApp.Services.Interfaces
{
    public interface ITokenService
    {
        Task<TokenModel> CreateTokenAsync(User user);
        Task<Guid> CheckValidRefreshToken(RestoreAccessTokenRequestModel model);
    }
}
