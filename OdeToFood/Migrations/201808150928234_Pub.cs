namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pub : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.RestaurantReviews", name: "name_Id", newName: "Restaurant_Id");
            RenameIndex(table: "dbo.RestaurantReviews", name: "IX_name_Id", newName: "IX_Restaurant_Id");
            AddColumn("dbo.RestaurantReviews", "name", c => c.String());
            AddColumn("dbo.RestaurantReviews", "Pub", c => c.Boolean(nullable: false));
            AddColumn("dbo.RestaurantReviews", "Comment", c => c.String());
            DropColumn("dbo.RestaurantReviews", "Body");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RestaurantReviews", "Body", c => c.String());
            DropColumn("dbo.RestaurantReviews", "Comment");
            DropColumn("dbo.RestaurantReviews", "Pub");
            DropColumn("dbo.RestaurantReviews", "name");
            RenameIndex(table: "dbo.RestaurantReviews", name: "IX_Restaurant_Id", newName: "IX_name_Id");
            RenameColumn(table: "dbo.RestaurantReviews", name: "Restaurant_Id", newName: "name_Id");
        }
    }
}
