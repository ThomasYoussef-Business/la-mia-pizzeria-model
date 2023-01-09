using La_Mia_Pizzeria_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace La_Mia_Pizzeria_1.Controllers {
    public class PizzaController : Controller {
        public IActionResult Index() {
            List<Pizza> pizzas = Pizza.GetPizzas();
            return View(pizzas);
        }
    }
}
