namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastUpdatedCol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "LastUpdatedDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurants", "LastUpdatedDateTime");
        }
    }
}
