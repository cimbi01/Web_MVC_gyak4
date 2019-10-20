using gyak4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gyak4.Controllers
{
    public class DiakokController : Controller
    {
        private static Random rnd = new Random();
        private static readonly List<Diak> diakok = new List<Diak>()
            {
                new Diak() { Nev = "Jani", PontSzam=rnd.Next(0, 500)},
                new Diak() { Nev = "Béla", PontSzam=220},
                new Diak() { Nev = "Alpaka", PontSzam=230},
                new Diak() { Nev = "Csicska", PontSzam=250},
                new Diak() { Nev = "Aladár", PontSzam=rnd.Next(0, 500)},
                new Diak() { Nev = "Pöcsi", PontSzam=rnd.Next(0, 500)},
                new Diak() { Nev = "Dani", PontSzam=rnd.Next(0, 500)}
            };
        // GET: Diakok
        public ActionResult MoViewData()
        {
            ViewData["diakok"] = diakok;
            return View();
        }
        public ActionResult MoViewBag()
        {
            ViewBag.diakok = diakok;
            return View();
        }
        public ActionResult MoErosenTipusos()
        {
            return View(diakok);
        }
    }
}