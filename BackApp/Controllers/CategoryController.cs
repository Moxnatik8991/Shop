using Microsoft.AspNetCore.Mvc;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Models;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.Controllers;

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

        var categoryFiltering = categories.Where(_ => _.CategoryId == null);

        var response = new BaseResponseModel<IEnumerable<Category>>();

        if (categoryFiltering.Count() > 0)
        {
            response.SetSuccessResponse(categoryFiltering);
        }
        else
        {
            response.SetSuccessResponse();
        }

        return response;
    }
}
