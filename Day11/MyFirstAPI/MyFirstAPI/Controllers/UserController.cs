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

        public UserController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        [Route("Login")]
        public ActionResult Login(UserDTO  userDTO)
        {
            var result = _loginService.Login(userDTO);
            if (result)
                return Ok("Login success");
            return BadRequest("Invalid username or password");
        }
        [HttpPost]
        [Route("Register")]
        public ActionResult Register(User user)
        {
            var result = _loginService.Register(user);
            if (result)
                return Ok("User Registered");
            return BadRequest("Could not register user");
        }

    }
}
