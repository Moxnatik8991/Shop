using Shop.Models.RequestModels;
using Shop.Models.ResponseModels;

namespace Shop.Services.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponseModel> Login(LoginRequestModel model);
    }
}
