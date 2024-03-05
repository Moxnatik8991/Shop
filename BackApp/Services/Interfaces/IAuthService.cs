using Shop.BackApp.Models;
using Shop.BackApp.Models.RequestModels;

namespace Shop.BackApp.Services.Interfaces
{
    public interface IAuthService
    {
        Task<TokenModel> Login(LoginRequestModel model);
    }
}
