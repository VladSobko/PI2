using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LR2ASP.Models;

namespace LR2ASP.Controllers
{
    public class HomeController : Controller
    {

        SportGoods[] equipment = {
         new SportGoods {Good_Id = 1, Name = "Футбольний мяч", Price = 400, Brand="Nike", Count=23, Category="Приладдя"},
         new SportGoods {Good_Id = 2, Name = "Лижі", Price = 1700, Brand="Track", Count=9, Category="Транспорт"},
         new SportGoods {Good_Id = 3, Name = "Кросівки",Price = 1250, Brand="Asics", Count=17,  Category="Одяг"},
         new SportGoods {Good_Id = 4, Name = "Велосипед",Price = 5900, Brand="Formula", Count=6, Category="Транспорт"},
         new SportGoods {Good_Id = 5, Name = "Спортивний костюм",Price = 850, Brand="Reebook", Count=28, Category="Одяг"},
     };

        public ActionResult Index()
        {
            return View(equipment);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}