using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Entity;
using Shop.Models;
using Shop.Services.Interfaces;

namespace Shop.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CategoryController
{

    private readonly ICategoryService _categoryServices;
    public CategoryController(ICategoryService categoryServices)
    {
        _categoryServices = categoryServices;
    }

    [HttpGet]
    public async Task<BaseResponseModel<IEnumerable<Category>>> GetAll()
    {
        var categories = await _categoryServices.GetAllAsync();

        var response = new BaseResponseModel<IEnumerable<Category>>();

        if (categories.Count() > 0)
        {
            response.SetSuccessResponse(categories);
        }
        else
        {
            response.SetSuccessResponse();
        }

        return response;
    }
}
