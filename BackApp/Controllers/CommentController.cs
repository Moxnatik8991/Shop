using Microsoft.AspNetCore.Mvc;
using Shop.BackApp.Models.RequestModels;
using Shop.BackApp.Models;
using Shop.BackApp.Services;
using Shop.BackApp.Services.Interfaces;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Helpers.FilteringAndPagination;

namespace Shop.BackApp.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentServices;
        public CommentController(ICommentService commentServices)
        {
            _commentServices = commentServices;
        }

        [HttpGet]
        public async Task<BaseResponseModel<IEnumerable<Comment>>> GetAll()
        {
            var comments = await _commentServices.GetAllAsync();

            var response = new BaseResponseModel<IEnumerable<Comment>>();

            if (comments.Count() > 0)
            {
                response.SetSuccessResponse(comments);
            }
            else
            {
                response.SetSuccessResponse();
            }

            return response;
        }

        [HttpGet("{id}")]
        public async Task<BaseResponseModel<IEnumerable<Comment>>> GetCommentsByProductId(Guid id, [FromQuery] PaginationParams paginationParams)
        {
            var categories = await _commentServices.GetCommentsByProductIdAsync(id, paginationParams, Response);

            var response = new BaseResponseModel<IEnumerable<Comment>>();

            response.SetSuccessResponse(categories);

            return response;
        }

        [HttpPut("{id}")]
        public async Task<BaseResponseModel<string>> Put(Guid id, [FromForm] CommentRequestModel model)
        {
            await _commentServices.UpdateAsync(id, model);

            var response = new BaseResponseModel<string>();
            response.SetSuccessResponse();

            return response;
        }

        [HttpGet("{id}")]
        public async Task<BaseResponseModel<Comment>> Get(Guid id)
        {
            var comment = await _commentServices.GetAsync(id);

            var response = new BaseResponseModel<Comment>();

            response.SetSuccessResponse(comment);

            return response;
        }

        [HttpPost]
        public async Task<BaseResponseModel<string>> Add([FromBody] CommentRequestModel model)
        {
            await _commentServices.AddAsync(model);

            var response = new BaseResponseModel<string>();

            response.SetSuccessResponse();

            return response;
        }

        [HttpDelete("{id}")]
        public async Task<BaseResponseModel<string>> Delete(Guid id)
        {
            await _commentServices.DeleteAsync(id);

            var response = new BaseResponseModel<string>();
            response.SetSuccessResponse();

            return response;
        }
    }
}
