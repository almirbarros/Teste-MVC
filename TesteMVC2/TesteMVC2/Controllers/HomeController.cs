using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteMVC2.Models;

namespace TesteMVC2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Numero()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult NumeroCalculo(NumeroModel modelo)
        {
            modelo.Resultado = modelo.Numero1 + modelo.Numero2;
            return View(modelo);
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