using FirstWebApp.Models;
using FirstWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly ILoginService _loginService;

        public UserController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            if(ModelState.IsValid)
            {
                var result = _loginService.Login(user);
                if (result)
                {
                    TempData.Add("username", user.Username);
                    HttpContext.Session.SetString("username", user.Username);
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.Message = "Invalid username or password";
            }
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserVM user)
        {
            if (ModelState.IsValid)
            {
                var result = _loginService.Register(user);
                if (result)
                {
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.Message = "Username already taken";
            }
            return View();
        }
    }
}
