namespace DiabetesTrackerASPAplikacija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nova : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Korisnik", "Terapija1_Id", "dbo.Terapija");
            DropIndex("dbo.Korisnik", new[] { "Terapija1_Id" });
            DropIndex("dbo.Terapija", new[] { "Korisnik_Id" });
            AlterColumn("dbo.Terapija", "KorisnikId", c => c.Int(nullable: false));
            DropColumn("dbo.Korisnik", "Terapija1_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Korisnik", "Terapija1_Id", c => c.Int());
            DropIndex("dbo.Terapija", new[] { "KorisnikId" });
            
            
            
            CreateIndex("dbo.Terapija", "Korisnik_Id");
            
            CreateIndex("dbo.Korisnik", "Terapija1_Id");
            AddForeignKey("dbo.Korisnik", "Terapija1_Id", "dbo.Terapija", "Id");
        }
    }
}
