namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedheightandweighttodouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Weight", c => c.Double(nullable: false));
            AlterColumn("dbo.Users", "Height", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Height", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Weight", c => c.Int(nullable: false));
        }
    }
}
