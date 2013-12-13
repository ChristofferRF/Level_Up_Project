namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tilbagetilDateCreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LogEntries", "DateCreated", c => c.String());
            DropColumn("dbo.LogEntries", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LogEntries", "Date", c => c.String());
            DropColumn("dbo.LogEntries", "DateCreated");
        }
    }
}
