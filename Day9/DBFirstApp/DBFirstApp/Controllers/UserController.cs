using DBFirstApp.Models;
using DBFirstApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstApp.Controllers
{
    public class UserController : Controller
    {
        
        private IUserService _loginService;

        public UserController(IUserService userservice)
        {
            _loginService = userservice;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(TblUser user)
        {
            if (ModelState.IsValid)
            {
                var result = _loginService.Login(user);
                if (result)
                {
                    //TempData.Add("username", user.Username);
                    HttpContext.Session.SetString("username", user.Username);
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.Message = "Invalid username or password";
            }
            return View();
        }
        public IActionResult Register()
        {
            UserVM user = new UserVM();
            return View(user);
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
