using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev_etiyopa_muhammet_burak_demir.Models.Siniflar;

namespace odev_etiyopa_muhammet_burak_demir.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Sehirs.ToList();
            return View(degerler);
        }
        
        [HttpGet]
        public ActionResult YeniSehir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSehir(Sehir a)
        {
            c.Sehirs.Add(a);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SehirSil(int id)
        {
            var s = c.Sehirs.Find(id);
            c.Sehirs.Remove(s);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SehirGetir(int id)
        {
            var sh = c.Sehirs.Find(id); 
            return View("SehirGetir", sh);
        }
        public ActionResult SehirGuncelle(Sehir s)
        {
            var shr = c.Sehirs.Find(s.ID);
            shr.Baslik=s.Baslik;
            c.SaveChanges();
            return RedirectToAction("Index"); 
        }
    }
}