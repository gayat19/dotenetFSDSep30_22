using Microsoft.AspNetCore.Mvc;
using FirstWebApp.Models;

namespace FirstWebApp.Controllers
{
    public class SampleController : Controller
    {
        //public string[] Index()
        //{
        //    return new string[] { "Hello","Hi","Welcome" };
        //}
        string username;
        public ActionResult Index()
        {
            username = "Ramu";
            ViewData["un"] = username;
            return View();
        }
        public ActionResult ShowData()
        {

            ViewBag.un = "Somu";
            return View();
        }
        public ActionResult Understand()
        {

            Employee employee = new Employee
            {
                Id = 101,
                Name = "Ramu",
                Age = 26
            };
            ViewData["emp1"] = employee;
            ViewBag.emp2 = employee;
            return View();
        }
        public ActionResult ModelExample()
        {
            Employee employee = new Employee
            {
                Id = 101,
                Name = "Ramu",
                Age = 26
            };
            return View(employee);
        }
    }
}
