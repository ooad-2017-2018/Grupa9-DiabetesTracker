namespace DiabetesTrackerASPAplikacija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sljedeca : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dnevni_unos", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.Nalaz", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.Podsjetnik", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.Terapija", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.Namirnica", "HranaId", "dbo.Dnevni_unos");
            DropForeignKey("dbo.Dnevni_unos", "KorisnikId1", "dbo.Korisnik");
            CreateTable(
                "dbo.UnosHrane",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Datum = c.DateTime(nullable: false),
                        TipKategorije = c.Int(nullable: false),
                        KorisnikId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Korisnik", t => t.KorisnikId)
                .Index(t => t.KorisnikId);
            
            CreateTable(
                "dbo.UnosNijeHrana",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tip = c.Int(nullable: false),
                        Vrijednost = c.Double(nullable: false),
                        Datum = c.DateTime(nullable: false),
                        TipKategorije = c.Int(nullable: false),
                        KorisnikId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Korisnik", t => t.KorisnikId)
                .Index(t => t.KorisnikId);
            
            AddColumn("dbo.Namirnica", "UnosHraneId", c => c.Int(nullable: false));
            CreateIndex("dbo.Namirnica", "UnosHraneId");
            AddForeignKey("dbo.Namirnica", "UnosHraneId", "dbo.UnosHrane", "Id");
            AddForeignKey("dbo.Dnevni_unos", "KorisnikId", "dbo.Korisnik", "Id");
            AddForeignKey("dbo.Nalaz", "KorisnikId", "dbo.Korisnik", "Id");
            AddForeignKey("dbo.Podsjetnik", "KorisnikId", "dbo.Korisnik", "Id");
            AddForeignKey("dbo.Terapija", "KorisnikId", "dbo.Korisnik", "Id");
            AddForeignKey("dbo.Namirnica", "HranaId", "dbo.Dnevni_unos", "Id");
            AddForeignKey("dbo.Dnevni_unos", "KorisnikId1", "dbo.Korisnik", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dnevni_unos", "KorisnikId1", "dbo.Korisnik");
            DropForeignKey("dbo.Namirnica", "HranaId", "dbo.Dnevni_unos");
            DropForeignKey("dbo.Terapija", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.Podsjetnik", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.Nalaz", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.Dnevni_unos", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.Namirnica", "UnosHraneId", "dbo.UnosHrane");
            DropForeignKey("dbo.UnosNijeHrana", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.UnosHrane", "KorisnikId", "dbo.Korisnik");
            DropIndex("dbo.Namirnica", new[] { "UnosHraneId" });
            DropIndex("dbo.UnosNijeHrana", new[] { "KorisnikId" });
            DropIndex("dbo.UnosHrane", new[] { "KorisnikId" });
            DropColumn("dbo.Namirnica", "UnosHraneId");
            DropTable("dbo.UnosNijeHrana");
            DropTable("dbo.UnosHrane");
            AddForeignKey("dbo.Dnevni_unos", "KorisnikId1", "dbo.Korisnik", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Namirnica", "HranaId", "dbo.Dnevni_unos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Terapija", "KorisnikId", "dbo.Korisnik", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Podsjetnik", "KorisnikId", "dbo.Korisnik", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Nalaz", "KorisnikId", "dbo.Korisnik", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Dnevni_unos", "KorisnikId", "dbo.Korisnik", "Id", cascadeDelete: true);
        }
    }
}
