using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DiabetesTrackerASPAplikacija.Models
{
    public class DiabetesTrackerASPAplikacijaContext:DbContext
    {
        public DiabetesTrackerASPAplikacijaContext() : base("AzureConnection") //AzureConnection je naziv connection stringa u Web.config-u
        {
        }
        //dodavanjem klasa iz modela kao DbSet iste će biti mapirane u bazu podataka

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Doktor> Doktor { get; set; }
        public DbSet<Hrana> Hrana { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Nalaz> Nalaz { get; set; }
        public DbSet<Namirnica> Namirnica { get; set; }
        public DbSet<Nije_hrana> NijeHrana { get; set; }
        public DbSet<Podsjetnik> Podsjetnik { get; set; }
        public DbSet<Terapija> Terapija { get; set; }
        public DbSet<Dnevni_unos> DnevniUnos { get; set; }
        public DbSet<NamirnicaHranaPoveznica> NamirnicaHranaPoveznica { get; set; }
        public DbSet<UnosHrane> UnosHrane { get; set; }
        public DbSet<UnosNijeHrana> UnosNijeHrana { get; set; }
        public DbSet<NamirnicaDodatno> NamirnicaDodatno { get; set; }
        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}