using Microsoft.AspNetCore.Mvc;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Models;
using Shop.BackApp.Models.RequestModels;
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

    [HttpGet("{id}")]
    public async Task<BaseResponseModel<Category>> Get(Guid id)
    {
        var category = await _categoryServices.GetAsync(id);

        var response = new BaseResponseModel<Category>();

        response.SetSuccessResponse(category);

        return response;
    }

    [HttpPost]
    public async Task<BaseResponseModel<string>> Add([FromForm] CategoryRequestModel model)
    {
        await _categoryServices.AddAsync(model);

        var response = new BaseResponseModel<string>();

        response.SetSuccessResponse();

        return response;
    }

    [HttpPut("{id}")]
    public async Task<BaseResponseModel<string>> Put(Guid id, [FromForm] CategoryRequestModel model)
    {
        await _categoryServices.UpdateAsync(id, model);

        var response = new BaseResponseModel<string>();
        response.SetSuccessResponse();

        return response;

    }

    [HttpDelete("{id}")]
    public async Task<BaseResponseModel<string>> Delete(Guid id)
    {
        await _categoryServices.DeleteAsync(id);

        var response = new BaseResponseModel<string>();
        response.SetSuccessResponse();

        return response;
    }
}
