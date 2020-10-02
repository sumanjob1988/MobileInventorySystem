namespace MobileInventorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MobileInventoryMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MobileModels",
                c => new
                    {
                        Iemi = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Company = c.String(unicode: false),
                        Model = c.String(unicode: false),
                        Ram = c.Int(),
                        Memory = c.Int(),
                        Color = c.String(unicode: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Iemi);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MobileModels");
        }
    }
}
