using Shop.BackApp.Models;
using Shop.BackApp.Models.RequestModels;

namespace Shop.BackApp.Services.Interfaces
{
    public interface IAuthService
    {
        Task<TokenModel> LoginAsync(LoginRequestModel model);
        Task<TokenModel> RestoreAccessTokenAsync(RestoreAccessTokenRequestModel model);
    }
}
