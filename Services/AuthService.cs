using Shop.Domain.Entity;
using Shop.Middleware.Exceptions;
using Shop.Models;
using Shop.Models.RequestModels;
using Shop.Repository;
using Shop.Services.Interfaces;

namespace Shop.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        public AuthService(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        public async Task<TokenModel> Login(LoginRequestModel model)
        {
            var user = await _userRepository.GetUserByEmail(model.Email);

            if (user == null)
                throw new NotFoundException<User>();

            //TODO: Check password User!!!

            var token = await _tokenService.CreateToken(user);

            return token;
        }
    }
}
