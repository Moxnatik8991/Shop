using Microsoft.AspNetCore.Mvc;
using Shop.Abstractions;
using Shop.Domain.Entity;

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
        public async Task<IEnumerable<User>> Get()
        {
            var users = await _userRepository.GetAllAsync();

            return users;
        }

        [HttpGet("{id}")]
        public async Task<User> Get(Guid id)
        {
            var user = await _userRepository.GetAsync(id);

            return user;
        }


        [HttpPost]
        public async Task<User> Post([FromBody] User user)
        {
            user.Id = new Guid();
            await _userRepository.AddAsync(user);

            return user;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] User entity)
        {
            var user = await _userRepository.GetAsync(id);

            if (user == null)
            {
                return NotFound("Not Found");
            }

            await _userRepository.UpdateAsync(entity);

            return Ok();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var user = await _userRepository.GetAsync(id);

            if (user == null)
            {
                return NotFound("Not Found");
            }

            await _userRepository.DeleteAsync(id);

            return Ok();

        }
    }
}
