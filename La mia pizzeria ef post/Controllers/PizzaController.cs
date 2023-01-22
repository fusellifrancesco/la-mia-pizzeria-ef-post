using Microsoft.AspNetCore.Mvc;
using NetCore_01.Models;
using La_mia_pizzeria_Model.Utils;

namespace La_mia_pizzeria_Model.Controllers {
    public class PizzaController : Controller {

        public IActionResult Index() {

            List<Pizza> ListaPizze = PizzaData.GetPizze();

            return View("Index", ListaPizze);
        }

        public IActionResult Details(int id) {
            List<Pizza> ListaPizze = PizzaData.GetPizze();

            foreach (Pizza pizze in ListaPizze) {
                if (pizze.Id == id) {
                    return View(pizze);
                }
            }

            return NotFound("La pizza con l'id cercato non esiste!");
        }
    }
}
