using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace odev_etiyopa_muhammet_burak_demir.Models.Siniflar
{
    public class Uyeler
    {
        [Key]
        public int KulId { get; set; }
        public string KulAdi { get; set; }
        public string Parola { get; set; }
    }
}