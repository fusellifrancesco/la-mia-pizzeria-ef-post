using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop.Infrastructure;
using NetCore_01.Models;

namespace La_mia_pizzeria_ef_post.Controllers {
    public class PizzaController : Controller {

        public IActionResult Index() {
            return View();
        }
        
    }
}
