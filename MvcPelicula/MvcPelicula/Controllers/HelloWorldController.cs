using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public ActionResult Welcome(string name,string surname, int numberTimes = 1)
        {
            ViewBag.Message = "Hola " + name + " " + surname + ", ";
            ViewBag.numberTimes = numberTimes;

            return View();
        }
    }
}