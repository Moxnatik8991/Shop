using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Models.RequestModels;
using Shop.Models.ResponseModels;
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
    /// Sample parameters:
    ///     In developing !!!
    /// </remarks>
    [HttpPost]
    public async Task<BaseResponseModel<AuthResponseModel>> Login (LoginRequestModel loginModel)
    {
        var token = await _authService.Login(loginModel);

        var response = new BaseResponseModel<AuthResponseModel>();
        response.SetSuccessResponse(token);

        return response;
    }

}