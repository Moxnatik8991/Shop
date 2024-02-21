using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Entity;
using Shop.Models;
using Shop.Services;

namespace Shop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController
    {
        private readonly IProductServices _productServices;
        public ProductController(IProductServices productServices)
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
    }
}
