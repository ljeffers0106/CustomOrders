namespace CustomOrder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "EmailAddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "EmailAddress");
        }
    }
}
