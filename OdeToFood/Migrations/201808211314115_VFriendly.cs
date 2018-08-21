namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class VFriendly : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Restaurants", "City");
            DropColumn("dbo.Restaurants", "Country");
            DropColumn("dbo.RestaurantReviews", "Pub");
        }

        public override void Down()
        {
            AddColumn("dbo.RestaurantReviews", "Pub", c => c.Boolean(nullable: false));
            AddColumn("dbo.Restaurants", "Country", c => c.String());
            AddColumn("dbo.Restaurants", "City", c => c.String());
        }
    }
}
