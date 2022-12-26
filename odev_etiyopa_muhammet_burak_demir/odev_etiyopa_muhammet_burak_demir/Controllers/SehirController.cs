using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev_etiyopa_muhammet_burak_demir.Models.Siniflar;

namespace odev_etiyopa_muhammet_burak_demir.Controllers
{
    public class SehirController : Controller
    {
        // GET: Sehir
        Context c = new Context();
        public ActionResult Index()
        {
            var sehirler = c.Sehirs.ToList();
            return View(sehirler);
        }
    }
}