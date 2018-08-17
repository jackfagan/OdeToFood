namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VFriendy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "VFriendly", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurants", "VFriendly");
        }
    }
}
