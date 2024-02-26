using Shop.Models;
using Shop.Models.RequestModels;

namespace Shop.Services.Interfaces
{
    public interface IAuthService
    {
        Task<TokenModel> Login(LoginRequestModel model);
    }
}
