using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace odev_etiyopa_muhammet_burak_demir.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresEt> AdresEts { get; set; }
        public DbSet<Yerler> Yerlers { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Rehber> Rehbers { get; set; }
        public DbSet<ozellik> ozelliks { get; set; }
        public DbSet<Sehir> Sehirs { get; set; }
        public DbSet<Sehirler> Sehirlers { get; set; }
        public DbSet<anaresimsld> Anaresimslds { get; set; }
        public DbSet<Kahve> Kahves { get; set; }
        public DbSet<Uyeler> Uyelers { get; set; }


    }
}