using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gyak4.Controllers
{
    public class KorFormController : Controller
    {
        // GET: KorForm
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(double r)
        {
            double terulet = Math.Pow(r, 2) * Math.PI;
            ViewBag.Eredmeny = "Sugár: " + r + ", terület: " + terulet;
            return View();
        }
    }
}