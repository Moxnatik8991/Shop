using Microsoft.AspNetCore.Mvc;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Helpers.FilteringAndPagination;
using Shop.BackApp.Models;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProductController
{
    private readonly IProductService _productServices;
    public ProductController(IProductService productServices)
    {
        _productServices = productServices;
    }

    [HttpGet]
    public async Task<BaseResponseModel<IEnumerable<Product>>> GetAll()
    {
        var products = await _productServices.GetAllAsync();

        var response = new BaseResponseModel<IEnumerable<Product>>();
        response.SetSuccessResponse(products);

        return response;
    }


    /// <remarks>
    /// Sample parameters:
    /// 
    ///     OrderBy: [{"id": "name", "desc": true}, {"id": "price", "desc": false}]
    ///     
    ///     SearchTerm: Dildo   //any text, (будет кастомный поиск, можете использовать для поиска товара по сайту, могу навесить любую логику)
    ///     
    ///     ColumnFilters: [{"id": "price", "value": "6"}] or [{"id": "price", "lowerValue": "1", "upperValue": "9"}]   //lowerValue and upperValue only for numerical values 
    ///     
    ///     ColumnFilters: [{"id": "name", "value": "Lamp"}, {"id": "price", "lowerValue": "1", "upperValue": "9"}]     //can accept several filtering rules
    /// 
    /// </remarks>
    [HttpGet]
    public async Task<BaseResponseModel<IEnumerable<Product>>> GetWithFilteringAndPagination([FromQuery] SearchParams searchParam)
    {
        var products = await _productServices.GetWithFilteringAndPagination(searchParam);

        var response = new BaseResponseModel<IEnumerable<Product>>();

        if (products.Count() > 0)
        {
            response.SetSuccessResponse(products);
        }
        else
        {
            response.SetSuccessResponse();
        }

        return response;
    }

    [HttpGet("{id}")]
    public async Task<BaseResponseModel<Product>> Get(Guid id)
    {
        var product = await _productServices.GetAsync(id);

        var response = new BaseResponseModel<Product>();
        response.SetSuccessResponse(product);

        return response;
    }

}
