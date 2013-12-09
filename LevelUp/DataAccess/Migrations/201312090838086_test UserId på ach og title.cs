namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testUserIdpåachogtitle : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Achievements", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Titles", "User_UserId", "dbo.Users");
            DropIndex("dbo.Achievements", new[] { "User_UserId" });
            DropIndex("dbo.Titles", new[] { "User_UserId" });
            RenameColumn(table: "dbo.Achievements", name: "User_UserId", newName: "UserId");
            RenameColumn(table: "dbo.Titles", name: "User_UserId", newName: "UserId");
            AlterColumn("dbo.Achievements", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Titles", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Achievements", "UserId");
            CreateIndex("dbo.Titles", "UserId");
            AddForeignKey("dbo.Achievements", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
            AddForeignKey("dbo.Titles", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Titles", "UserId", "dbo.Users");
            DropForeignKey("dbo.Achievements", "UserId", "dbo.Users");
            DropIndex("dbo.Titles", new[] { "UserId" });
            DropIndex("dbo.Achievements", new[] { "UserId" });
            AlterColumn("dbo.Titles", "UserId", c => c.Int());
            AlterColumn("dbo.Achievements", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Titles", name: "UserId", newName: "User_UserId");
            RenameColumn(table: "dbo.Achievements", name: "UserId", newName: "User_UserId");
            CreateIndex("dbo.Titles", "User_UserId");
            CreateIndex("dbo.Achievements", "User_UserId");
            AddForeignKey("dbo.Titles", "User_UserId", "dbo.Users", "UserId");
            AddForeignKey("dbo.Achievements", "User_UserId", "dbo.Users", "UserId");
        }
    }
}
