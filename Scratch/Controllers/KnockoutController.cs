using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scratch.Controllers
{
    public class AvailableMeal
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class KnockoutController : Controller
    {
        //
        // GET: /Knockout/

        public ActionResult Index()
        {
            return View("Example1");
        }

        public ActionResult Example1()
        {
            return View();
        }

        public ActionResult Example2()
        {
            return View();
        }

        public JsonResult Mail()
        {
            List<string> mail = new List<string>() { "Mail1", "Mail2" };
 
            return this.Json(mail, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AvailableMeals(int id)
        {
            var availableMeals = new List<AvailableMeal>()
            {
                new AvailableMeal{ Name = "Burger", Price = 199.00M + id },
                new AvailableMeal{ Name = "Pizza", Price = 599.00M + id }
            };

            return this.Json(availableMeals, JsonRequestBehavior.AllowGet);
        }
    }
}
