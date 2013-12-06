namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAchievementsandTitles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Achievements",
                c => new
                    {
                        AchievementId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Value = c.Int(nullable: false),
                        DateAchieved = c.DateTime(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.AchievementId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Titles",
                c => new
                    {
                        TitleId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        DateAchieved = c.DateTime(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.TitleId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            AddColumn("dbo.Users", "Level", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Xp", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Titles", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Achievements", "User_UserId", "dbo.Users");
            DropIndex("dbo.Titles", new[] { "User_UserId" });
            DropIndex("dbo.Achievements", new[] { "User_UserId" });
            DropColumn("dbo.Users", "Xp");
            DropColumn("dbo.Users", "Level");
            DropTable("dbo.Titles");
            DropTable("dbo.Achievements");
        }
    }
}
