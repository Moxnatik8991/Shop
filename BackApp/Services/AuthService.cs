using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Middleware.Exceptions;
using Shop.BackApp.Models;
using Shop.BackApp.Models.RequestModels;
using Shop.BackApp.Repository;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.Services
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
