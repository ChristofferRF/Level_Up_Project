namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserIdpåLogs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LogEntries", "User_UserId", "dbo.Users");
            DropIndex("dbo.LogEntries", new[] { "User_UserId" });
            RenameColumn(table: "dbo.LogEntries", name: "User_UserId", newName: "UserId");
            AlterColumn("dbo.LogEntries", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.LogEntries", "UserId");
            AddForeignKey("dbo.LogEntries", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LogEntries", "UserId", "dbo.Users");
            DropIndex("dbo.LogEntries", new[] { "UserId" });
            AlterColumn("dbo.LogEntries", "UserId", c => c.Int());
            RenameColumn(table: "dbo.LogEntries", name: "UserId", newName: "User_UserId");
            CreateIndex("dbo.LogEntries", "User_UserId");
            AddForeignKey("dbo.LogEntries", "User_UserId", "dbo.Users", "UserId");
        }
    }
}
