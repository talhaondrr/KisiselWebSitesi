using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KisiselWebSitesi.Models.Classes;

namespace KisiselWebSitesi.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.HomePages.ToList();
            return View(deger);
        }
        public PartialViewResult ikonlar()
        {
            var deger = c.Ikons.ToList();
            return PartialView(deger);
        }
    }
}   