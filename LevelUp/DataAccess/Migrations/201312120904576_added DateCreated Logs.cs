namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDateCreatedLogs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LogEntries", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LogEntries", "DateCreated");
        }
    }
}
