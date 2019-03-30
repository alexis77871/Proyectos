using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registro.Models;
namespace Registro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Bienvenida()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
        public ActionResult OtherView()
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }
            else
            {
                Datos data = new Datos();
                return View(data);
            }

        }
        public ActionResult Resultado(Datos obj)
        {
            return View(obj);

        }
    }
}