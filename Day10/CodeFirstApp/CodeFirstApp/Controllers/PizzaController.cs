using CodeFirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzaStoreContext _context;

        public PizzaController(PizzaStoreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var pizzas = _context.Pizzas.ToList();
            return View(pizzas);
        }
    }
}
