﻿using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Helpers;
using Shop.BackApp.Middleware.Exceptions;
using Shop.BackApp.Models;
using Shop.BackApp.Models.RequestModels;
using Shop.BackApp.Repository.Interfaces;
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
                throw new NotFoundException(nameof(user));

            var passwordHash = PasswordHasherHelper.ComputeHash(model.Password, user.PasswordSalt);

            if (!string.Equals(passwordHash, user.PasswordHash))
                throw new CustomException("Incorrect password");

            var token = await _tokenService.CreateToken(user);

            return token;
        }
    }
}
