namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserNamerettet : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserName", c => c.String());
        }
    }
}
