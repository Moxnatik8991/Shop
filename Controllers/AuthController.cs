using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Models.RequestModels;
using Shop.Services.Interfaces;

namespace Shop.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class AuthController
{
    private readonly IAuthService _authService;
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    /// <remarks>
    ///     In developing !!!
    /// </remarks>
    [HttpPost]
    public async Task<BaseResponseModel<TokenModel>> Login (LoginRequestModel loginModel)
    {
        var token = await _authService.Login(loginModel);

        var response = new BaseResponseModel<TokenModel>();
        response.SetSuccessResponse(token);

        return response;
    }

}