namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Author : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RestaurantReviews", "Author", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RestaurantReviews", "Author");
        }
    }
}
