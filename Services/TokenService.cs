using Microsoft.IdentityModel.Tokens;
using Shop.Domain.Entity;
using Shop.Models;
using Shop.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Shop.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<TokenModel> CreateToken(User user)
        {
            var accessTokenExpirationDate = DateTime.Now.AddMonths(1);

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
            var jwt =  tokenHandler.WriteToken(token);

            var tokenModel = new TokenModel
            {
                AccessToken = jwt,
                AccessTokenExpirationDate = accessTokenExpirationDate,
            };

            return tokenModel;
        }
    }
}
