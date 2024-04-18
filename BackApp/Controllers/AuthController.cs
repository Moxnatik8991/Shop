using Microsoft.AspNetCore.Mvc;
using Shop.BackApp.Models;
using Shop.BackApp.Models.RequestModels;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.Controllers;

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
    /// </remarks>
    [HttpPost]
    public async Task<BaseResponseModel<TokenModel>> Login(LoginRequestModel loginModel)
    {

        var token = await _authService.LoginAsync(loginModel);

        var response = new BaseResponseModel<TokenModel>();
        response.SetSuccessResponse(token);

        return response;
    }

    [HttpPost]
    public async Task<BaseResponseModel<TokenModel>> RestoreAccessToken(RestoreAccessTokenRequestModel model)
    {

        var token = await _authService.RestoreAccessTokenAsync(model);

        var response = new BaseResponseModel<TokenModel>();
        response.SetSuccessResponse(token);

        return response;
    }
}