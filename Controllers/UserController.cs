using Microsoft.AspNetCore.Mvc;
using Shop.Abstractions;
using Shop.Domain.Entity;
using Shop.Middleware.Exceptions;
using Shop.Models;

namespace Shop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IRepository<User> _userRepository;
        public UserController(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<BaseResponseModel<IEnumerable<User>>> Get()
        {
            var users = await _userRepository.GetAllAsync();

            var response = new BaseResponseModel<IEnumerable<User>>();
            response.SetSuccessResponse(users);

            return response;
        }

        [HttpGet("{id}")]
        public async Task<BaseResponseModel<User>> Get(Guid id)
        {
            var user = await _userRepository.GetAsync(id);

            var response = new BaseResponseModel<User>();
            response.SetSuccessResponse(user);

            return response;
        }


        [HttpPost]
        public async Task<BaseResponseModel<User>> Post([FromBody] User user)
        {
            user.Id = new Guid();
            await _userRepository.AddAsync(user);

            var response = new BaseResponseModel<User>();
            response.SetSuccessResponse(user);

            return response;
        }

        [HttpPut("{id}")]
        public async Task<BaseResponseModel<string>> Put(Guid id, [FromBody] User entity)
        {
            var user = await _userRepository.GetAsync(id);

            if (user == null)
            {
                throw new NotFoundException<User>();
            }

            await _userRepository.UpdateAsync(entity);

            var response = new BaseResponseModel<string>();
            response.SetSuccessResponse();

            return response;

        }

        [HttpDelete("{id}")]
        public async Task<BaseResponseModel<string>> Delete(Guid id)
        {
            var user = await _userRepository.GetAsync(id);

            if (user == null)
            {
                throw new NotFoundException<User>();
            }

            await _userRepository.DeleteAsync(id);

            var response = new BaseResponseModel<string>();
            response.SetSuccessResponse();

            return response;

        }
    }
}
