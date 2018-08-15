namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.RestaurantReviews", name: "Restaurant_Id", newName: "name_Id");
            RenameIndex(table: "dbo.RestaurantReviews", name: "IX_Restaurant_Id", newName: "IX_name_Id");
            DropColumn("dbo.RestaurantReviews", "ResturantId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RestaurantReviews", "ResturantId", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.RestaurantReviews", name: "IX_name_Id", newName: "IX_Restaurant_Id");
            RenameColumn(table: "dbo.RestaurantReviews", name: "name_Id", newName: "Restaurant_Id");
        }
    }
}
