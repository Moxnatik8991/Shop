using Azure;
using Azure.Core;
using Microsoft.IdentityModel.Tokens;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Helpers;
using Shop.BackApp.Middleware.Exceptions;
using Shop.BackApp.Models;
using Shop.BackApp.Models.RequestModels;
using Shop.BackApp.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Shop.BackApp.Services;
public class TokenService : ITokenService
{
    private readonly IConfiguration _configuration;

    public TokenService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<TokenModel> CreateTokenAsync(User user)
    {
        var accessTokenExpirationDate = DateTime.UtcNow.AddMinutes(1);
        var refreshTokenExpirationDate = DateTime.UtcNow.AddMinutes(2);

        List<Claim> claims = new List<Claim> {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            //new Claim(ClaimTypes.Role, "User"),
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
            _configuration.GetSection("JWT:Secret").Value!));

        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Expires = accessTokenExpirationDate,
            SigningCredentials = new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256),
            Subject = new ClaimsIdentity(claims)
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var jwt = tokenHandler.WriteToken(token);

        var paramsForRefreshTokenHelper = new ParamsForRefreshTokenHelper
        {
            UserId = user.Id,
            AccessToken = jwt,
            RefreshTokenExpirationDate = refreshTokenExpirationDate,
            RefreshSecret = _configuration.GetSection("JWT:RefreshSecret").Value!
        };

        var tokenModel = new TokenModel
        {
            AccessToken = jwt,
            AccessTokenExpirationDate = accessTokenExpirationDate,

            RefreshToken = paramsForRefreshTokenHelper.GenerateRefreshToken(),
            RefreshTokenExpirationDate = paramsForRefreshTokenHelper.RefreshTokenExpirationDate
        };

        return tokenModel;
    }

    public async Task<Guid> CheckValidRefreshToken(RestoreAccessTokenRequestModel model)
    {

        var paramsForRefreshTokenHelper = new ParamsForRefreshTokenHelper() { RefreshSecret = _configuration.GetSection("JWT:RefreshSecret").Value! };

        paramsForRefreshTokenHelper.DecryptRefreshToken(model.RefreshToken);


        if (paramsForRefreshTokenHelper.RefreshTokenExpirationDate > DateTime.UtcNow && 
            string.Equals(model.AccessToken, paramsForRefreshTokenHelper.AccessToken))
        {
            return paramsForRefreshTokenHelper.UserId;
        }
        else
        {
            throw new CustomException("Refresh token lifetime has expired!");
        }
    }
}