using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Shop.Abstractions;
using Shop.Domain;
using Shop.Domain.Entity;
using Shop.Helpers.FilteringAndPagination;
using Shop.Models;
using Shop.Services;
using System.Linq.Expressions;
using System.Text.Json;
using static Shop.Controllers.ProductController;

namespace Shop.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductController
    {
        private readonly IProductServices _productServices;
        private readonly DataContext _dataContext;
        public ProductController(IProductServices productServices, DataContext dataContext)
        {
            _productServices = productServices;
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<BaseResponseModel<IEnumerable<Product>>> GetAll()
        {
            var products = await _productServices.GetAllAsync();

            var response = new BaseResponseModel<IEnumerable<Product>>();
            response.SetSuccessResponse(products);

            return response;
        }

        [HttpGet]
        public async Task<BaseResponseModel<IEnumerable<Product>>> GetWithFilteringAndPagination([FromQuery] SearchParams searchParam)
        {
            var products = await _productServices.GetWithFilteringAndPagination(searchParam);

            var response = new BaseResponseModel<IEnumerable<Product>>();
            response.SetSuccessResponse(products);

            return response;
        }

    }
}
