namespace DiabetesTrackerASPAplikacija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nova2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Namirnica", "Hrana_Id", "dbo.Dnevni_unos");
            DropIndex("dbo.Namirnica", new[] { "Hrana_Id" });
            DropColumn("dbo.Namirnica", "Hrana_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Namirnica", "Hrana_Id", c => c.Int());
            CreateIndex("dbo.Namirnica", "Hrana_Id");
            AddForeignKey("dbo.Namirnica", "Hrana_Id", "dbo.Dnevni_unos", "Id");
        }
    }
}
