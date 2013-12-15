namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forsøgpålogentryfix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "PrivacyName", c => c.String());
            AlterColumn("dbo.Users", "PrivacyAge", c => c.String());
            AlterColumn("dbo.Users", "PrivacyWeight", c => c.String());
            AlterColumn("dbo.Users", "PrivacyHeight", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "PrivacyHeight", c => c.String());
            AlterColumn("dbo.Users", "PrivacyWeight", c => c.String());
            AlterColumn("dbo.Users", "PrivacyAge", c => c.String());
            AlterColumn("dbo.Users", "PrivacyName", c => c.String());
        }
    }
}
