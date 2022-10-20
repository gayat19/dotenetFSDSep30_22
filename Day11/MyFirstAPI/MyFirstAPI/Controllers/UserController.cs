using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Models;
using MyFirstAPI.Services;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly ILogger<UserController> _logger;

        public UserController(ILoginService loginService,ILogger<UserController> logger)
        {
            _loginService = loginService;
            _logger = logger;
        }
        [HttpPost]
        [Route("Login")]
        public ActionResult Login(UserDTO  userDTO)
        {
            _logger.LogInformation("Login Hit");
            var result = _loginService.Login(userDTO);
            if (result != null)
                return Ok(result);
            return BadRequest("Invalid username or password");
        }
        [HttpPost]
        [Route("Register")]
        public ActionResult Register(UserPassDTO user)
        {
            var result = _loginService.Register(user);
            if(result != null)
                return Ok(result);
            return BadRequest("Could not register user");
        }

    }
}
