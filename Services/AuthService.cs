using Shop.Models.RequestModels;
using Shop.Models.ResponseModels;
using Shop.Repository;
using Shop.Services.Interfaces;

namespace Shop.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<AuthResponseModel> Login(LoginRequestModel model)
        {
            
            var user = await _userRepository.GetUserByEmail(model.Email);

            return new AuthResponseModel { };
        }
    }
}
