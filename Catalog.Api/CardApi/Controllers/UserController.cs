using Cards.Api.Model;
using Cards.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Cards.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {


        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<User>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            var result = await _userService.GetAllUser();
            return Ok(result);
        }


        [HttpGet("user/{id}", Name = "GetUser")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]

        public async Task<ActionResult<Card>> GetUser(int id)
        {
            if (id <= 0)
                return BadRequest("Requesteted id card is not valid.");

            var result = await _userService.GetUser(id);
            if (result == null)
                return NotFound($"Card with {id} not found.");

            return Ok(result);
        }


        [HttpGet("createUser", Name = "createUser")]
        [ProducesResponseType(typeof(User), 200)]

        public async Task<ActionResult<User>> CreateCard([FromBody] User user)
        {
            var result = await _userService.CreateUser(user);
            return Ok(result);
        }
    }
}
