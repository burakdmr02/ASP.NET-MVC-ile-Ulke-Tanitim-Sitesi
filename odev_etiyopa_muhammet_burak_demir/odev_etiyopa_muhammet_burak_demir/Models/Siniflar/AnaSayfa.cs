using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace odev_etiyopa_muhammet_burak_demir.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int ID {get;set;}
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}