namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pub1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "Pub", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurants", "Pub");
        }
    }
}
