namespace DiabetesTrackerASPAplikacija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Spol = c.Int(nullable: false),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        PotvrdaPassworda = c.String(),
                        EMail = c.String(),
                        JMBG1 = c.String(),
                        Spol1 = c.Int(nullable: false),
                        DatumRodjenja = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Doktor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Spol = c.Int(nullable: false),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        PotvrdaPassworda = c.String(),
                        EMail = c.String(),
                        JMBG1 = c.String(),
                        Spol1 = c.Int(nullable: false),
                        DatumRodjenja = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dnevni_unos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Datum = c.DateTime(nullable: false),
                        TipKategorije = c.Int(nullable: false),
                        KorisnikId = c.Int(nullable: false),
                        Tip = c.Int(),
                        Vrijednost = c.Double(),
                        Kolicine=c.String(nullable:false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Korisnik_Id = c.Int(),
                        Korisnik_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Korisnik", t => t.KorisnikId, cascadeDelete: true)
                .ForeignKey("dbo.Korisnik", t => t.Korisnik_Id)
                .ForeignKey("dbo.Korisnik", t => t.Korisnik_Id1)
                .Index(t => t.KorisnikId)
                .Index(t => t.Korisnik_Id)
                .Index(t => t.Korisnik_Id1);
            
            CreateTable(
                "dbo.Korisnik",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipDijabetesa = c.String(),
                        Visina = c.Double(nullable: false),
                        Tezina = c.Double(nullable: false),
                        FizickaAktivnost = c.String(),
                        VrijednostHiperglikemije = c.Double(nullable: false),
                        VrijednostHipoglikemije = c.Double(nullable: false),
                        CiljaniNivoGlukoze = c.Double(nullable: false),
                        DonjaGranicaGlukoze = c.Double(nullable: false),
                        GornjaGranicaGlukoze = c.Double(nullable: false),
                        Tip = c.Int(nullable: false),
                        Lijekovi = c.String(),
                        DozaLijeka = c.String(),
                        Spol = c.Int(nullable: false),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        PotvrdaPassworda = c.String(),
                        EMail = c.String(),
                        JMBG1 = c.String(),
                        Spol1 = c.Int(nullable: false),
                        DatumRodjenja = c.DateTime(nullable: false),
                        Terapija1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Terapija", t => t.Terapija1_Id)
                .Index(t => t.Terapija1_Id);
            
            CreateTable(
                "dbo.Nalaz",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazivFajla = c.String(),
                        KorisnikId = c.Int(nullable: false),
                        Korisnik_Id = c.Int(),
                        Korisnik_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Korisnik", t => t.KorisnikId, cascadeDelete: true)
                .ForeignKey("dbo.Korisnik", t => t.Korisnik_Id)
                .ForeignKey("dbo.Korisnik", t => t.Korisnik_Id1)
                .Index(t => t.KorisnikId)
                .Index(t => t.Korisnik_Id)
                .Index(t => t.Korisnik_Id1);
            
            CreateTable(
                "dbo.Podsjetnik",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tip = c.Int(nullable: false),
                        Datum = c.DateTime(nullable: false),
                        Ponavljanje = c.Int(nullable: false),
                        Opis = c.String(),
                        KorisnikId = c.Int(nullable: false),
                        Korisnik_Id = c.Int(),
                        Korisnik_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Korisnik", t => t.KorisnikId, cascadeDelete: true)
                .ForeignKey("dbo.Korisnik", t => t.Korisnik_Id)
                .ForeignKey("dbo.Korisnik", t => t.Korisnik_Id1)
                .Index(t => t.KorisnikId)
                .Index(t => t.Korisnik_Id)
                .Index(t => t.Korisnik_Id1);
            
            CreateTable(
                "dbo.Terapija",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tip = c.Int(nullable: false),
                        KorisnikId = c.Int(nullable: false),
                        Korisnik_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Korisnik", t => t.KorisnikId, cascadeDelete: true)
                .ForeignKey("dbo.Korisnik", t => t.Korisnik_Id)
                .Index(t => t.KorisnikId)
                .Index(t => t.Korisnik_Id);
            
            CreateTable(
                "dbo.Namirnica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vrsta = c.String(),
                        Secer = c.Double(nullable: false),
                        Ugljikohidrati = c.Double(nullable: false),
                        Masti = c.Double(nullable: false),
                        HranaId = c.Int(nullable: false),
                        Hrana_Id = c.Int(),
                        Hrana_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dnevni_unos", t => t.HranaId, cascadeDelete: true)
                .ForeignKey("dbo.Dnevni_unos", t => t.Hrana_Id)
                .ForeignKey("dbo.Dnevni_unos", t => t.Hrana_Id1)
                .Index(t => t.HranaId)
                .Index(t => t.Hrana_Id)
                .Index(t => t.Hrana_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Namirnica", "Hrana_Id1", "dbo.Dnevni_unos");
            DropForeignKey("dbo.Namirnica", "Hrana_Id", "dbo.Dnevni_unos");
            DropForeignKey("dbo.Namirnica", "HranaId", "dbo.Dnevni_unos");
            DropForeignKey("dbo.Korisnik", "Terapija1_Id", "dbo.Terapija");
            DropForeignKey("dbo.Terapija", "Korisnik_Id", "dbo.Korisnik");
            DropForeignKey("dbo.Terapija", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.Podsjetnik", "Korisnik_Id1", "dbo.Korisnik");
            DropForeignKey("dbo.Podsjetnik", "Korisnik_Id", "dbo.Korisnik");
            DropForeignKey("dbo.Podsjetnik", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.Nalaz", "Korisnik_Id1", "dbo.Korisnik");
            DropForeignKey("dbo.Nalaz", "Korisnik_Id", "dbo.Korisnik");
            DropForeignKey("dbo.Nalaz", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.Dnevni_unos", "Korisnik_Id1", "dbo.Korisnik");
            DropForeignKey("dbo.Dnevni_unos", "Korisnik_Id", "dbo.Korisnik");
            DropForeignKey("dbo.Dnevni_unos", "KorisnikId", "dbo.Korisnik");
            DropIndex("dbo.Namirnica", new[] { "Hrana_Id1" });
            DropIndex("dbo.Namirnica", new[] { "Hrana_Id" });
            DropIndex("dbo.Namirnica", new[] { "HranaId" });
            DropIndex("dbo.Terapija", new[] { "Korisnik_Id" });
            DropIndex("dbo.Terapija", new[] { "KorisnikId" });
            DropIndex("dbo.Podsjetnik", new[] { "Korisnik_Id1" });
            DropIndex("dbo.Podsjetnik", new[] { "Korisnik_Id" });
            DropIndex("dbo.Podsjetnik", new[] { "KorisnikId" });
            DropIndex("dbo.Nalaz", new[] { "Korisnik_Id1" });
            DropIndex("dbo.Nalaz", new[] { "Korisnik_Id" });
            DropIndex("dbo.Nalaz", new[] { "KorisnikId" });
            DropIndex("dbo.Korisnik", new[] { "Terapija1_Id" });
            DropIndex("dbo.Dnevni_unos", new[] { "Korisnik_Id1" });
            DropIndex("dbo.Dnevni_unos", new[] { "Korisnik_Id" });
            DropIndex("dbo.Dnevni_unos", new[] { "KorisnikId" });
            DropTable("dbo.Namirnica");
            DropTable("dbo.Terapija");
            DropTable("dbo.Podsjetnik");
            DropTable("dbo.Nalaz");
            DropTable("dbo.Korisnik");
            DropTable("dbo.Dnevni_unos");
            DropTable("dbo.Doktor");
            DropTable("dbo.Admin");
        }
    }
}
