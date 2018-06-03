namespace DiabetesTrackerASPAplikacija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NamirnicaHranaPoveznica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NamirnicaId = c.Int(nullable: false),
                        HranaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            RenameColumn("dbo.Dnevni_unos", "Discriminator", "Kolicina");
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NamirnicaHranaPoveznica");
        }
    }
}
