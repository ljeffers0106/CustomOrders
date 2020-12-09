namespace CustomOrder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        Manufacturer = c.String(nullable: false),
                        Color = c.String(nullable: false),
                        UnitSize = c.String(nullable: false),
                        DateAdded = c.DateTimeOffset(nullable: false, precision: 7),
                        ProductActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
        }
    }
}
