namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ErrorFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LogEntries", "Date", c => c.String());
            DropColumn("dbo.LogEntries", "DateCreated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LogEntries", "DateCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.LogEntries", "Date");
        }
    }
}
