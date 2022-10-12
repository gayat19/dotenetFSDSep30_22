using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class EmpController : Controller
    {
        static List<Employee> employees = new List<Employee>
        {
            new Employee{Id=101,Name="Ramu",Age=32},
            new Employee{Id=102,Name="Somu",Age=39},
            new Employee{Id=103,Name="Komu",Age=22}
        };
        public IActionResult Index()
        {
            return View(employees);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            return View();
        }
    }
}
