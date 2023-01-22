using La_mia_pizzeria_ef_post.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop.Infrastructure;
using NetCore_01.Models;

namespace La_mia_pizzeria_ef_post.Controllers {
    public class PizzaController : Controller {

        public IActionResult Index() {
            
            using(PizzaContext db = new PizzaContext()) {
                
                List<Pizza> ListaPizze = db.Pizze.ToList<Pizza>();

                return View("Index", ListaPizze);
            }
            
        }

        public IActionResult Details(int id) {

            using (PizzaContext db = new PizzaContext()) {

                Pizza PizzaTrovata = db.Pizze
                    .Where(SingolaPizzaNelDb => SingolaPizzaNelDb.Id == id)
                    .FirstOrDefault();

                if (PizzaTrovata != null) {
                    
                    return View(PizzaTrovata);
                }

                return NotFound("La pizza con l'id cercato non esiste");
            }
        }

        [HttpGet]
        public IActionResult Create() {
            
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Pizza PizzaData) {

            if (!ModelState.IsValid) {

                return View("Create", PizzaData);

            }

            using (PizzaContext db = new PizzaContext()) {

                db.Pizze.Add(PizzaData);
                db.SaveChanges();

            }

            return RedirectToAction("Index");
        }   
    }
}
