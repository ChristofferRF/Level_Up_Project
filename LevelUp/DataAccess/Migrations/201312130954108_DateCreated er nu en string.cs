namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateCreatedernuenstring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LogEntries", "DateCreated", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LogEntries", "DateCreated", c => c.DateTime(nullable: false));
        }
    }
}
