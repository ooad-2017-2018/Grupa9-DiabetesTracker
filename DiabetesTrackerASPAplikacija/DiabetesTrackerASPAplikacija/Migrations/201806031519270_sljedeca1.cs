namespace DiabetesTrackerASPAplikacija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sljedeca1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NamirnicaDodatno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vrsta = c.String(nullable: false),
                        Secer = c.Double(nullable: false),
                        Ugljikohidrati = c.Double(nullable: false),
                        Masti = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NamirnicaDodatno");
        }
    }
}
