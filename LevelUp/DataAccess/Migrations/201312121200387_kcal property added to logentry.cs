namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kcalpropertyaddedtologentry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LogEntries", "Kcal", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LogEntries", "Kcal");
        }
    }
}
