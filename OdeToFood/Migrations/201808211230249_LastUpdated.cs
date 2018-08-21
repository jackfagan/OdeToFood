namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RestaurantReviews", "LastUpdated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RestaurantReviews", "LastUpdated");
        }
    }
}
