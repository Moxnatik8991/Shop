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
    ///     In developing !!!
    /// </remarks>
    [HttpPost]
    public async Task<BaseResponseModel<TokenModel>> Login(LoginRequestModel loginModel)
    {

        var token = await _authService.Login(loginModel);

        var response = new BaseResponseModel<TokenModel>();
        response.SetSuccessResponse(token);

        return response;
    }

}