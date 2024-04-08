using Microsoft.AspNetCore.Mvc;
using SampleAPI.Entity;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger) { 
        _logger=logger;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]User user)
        {

            if(user == null)
            {
                return BadRequest("Request is not valid");
            }

            if(!ModelState.IsValid) {
                return BadRequest("Required field should not be blank");
            }

            return Ok($"user {user.Name} added successfully");
        }
    }
}
