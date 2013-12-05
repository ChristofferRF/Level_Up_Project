namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correctedColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LogEntries", "Hours", c => c.Int(nullable: false));
            AddColumn("dbo.LogEntries", "Seconds", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LogEntries", "Seconds");
            DropColumn("dbo.LogEntries", "Hours");
        }
    }
}
