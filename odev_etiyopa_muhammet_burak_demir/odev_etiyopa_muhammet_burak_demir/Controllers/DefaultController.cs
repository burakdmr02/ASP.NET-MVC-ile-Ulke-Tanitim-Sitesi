using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev_etiyopa_muhammet_burak_demir.Models.Siniflar;

namespace odev_etiyopa_muhammet_burak_demir.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Anaresimslds.Take(4).ToList();
            return View(degerler);
        } 
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Anaresimslds.OrderByDescending(x =>x.ID == 6).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Anaresimslds.Where(x => x.ID == 19).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Anaresimslds.ToList();
            return PartialView(deger);
        }


    }
}