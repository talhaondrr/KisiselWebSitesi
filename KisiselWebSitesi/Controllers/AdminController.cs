using KisiselWebSitesi.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebSitesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.HomePages.ToList();
            return View(deger);
        }
        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.HomePages.Find(id);
            return View("AnaSayfaGetir", ag);
        }
        public ActionResult AnaSayfaGüncelle(HomePage x)
        {
            var ag = c.HomePages.Find(x.id);
            ag.isim = x.isim;
            ag.profil = x.profil;
            ag.unvan = x.unvan;
            ag.aciklama = x.aciklama;
            ag.iletisim = x.iletisim;
            c.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public ActionResult ikonListesi()
        {
            var deger = c.Ikons.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIkon(ikonlar p)
        {
            c.Ikons.Add(p);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }
        public ActionResult IkonGetir(int id)
        {
            var ig = c.Ikons.Find(id);
            return View("IkonGetir", ig);


        }
        public ActionResult IkonGüncelle(ikonlar x)
        {
            var ig = c.Ikons.Find(x.id);
            ig.ikon = x.ikon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("ikonListesi");

        }
        public ActionResult IkonSil(int id)
        {
            var sl = c.Ikons.Find(id);
            c.Ikons.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("IkonListesi");

        }
    }
}