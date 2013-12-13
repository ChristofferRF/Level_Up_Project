namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedattributesUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "privacyName", c => c.String());
            AddColumn("dbo.Users", "privacyAge", c => c.String());
            AddColumn("dbo.Users", "privacyWeight", c => c.String());
            AddColumn("dbo.Users", "privacyHeight", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "privacyHeight");
            DropColumn("dbo.Users", "privacyWeight");
            DropColumn("dbo.Users", "privacyAge");
            DropColumn("dbo.Users", "privacyName");
        }
    }
}
