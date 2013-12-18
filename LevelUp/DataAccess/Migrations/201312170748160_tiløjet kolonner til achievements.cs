namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tiløjetkolonnertilachievements : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Achievements", "UserId", "dbo.Users");
            DropIndex("dbo.Achievements", new[] { "UserId" });
            CreateTable(
                "dbo.UserAchievements",
                c => new
                    {
                        User_UserId = c.Int(nullable: false),
                        Achievement_AchievementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserId, t.Achievement_AchievementId })
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .ForeignKey("dbo.Achievements", t => t.Achievement_AchievementId, cascadeDelete: true)
                .Index(t => t.User_UserId)
                .Index(t => t.Achievement_AchievementId);
            
            AddColumn("dbo.Achievements", "XpToAchieve", c => c.Long(nullable: false));
            AddColumn("dbo.Achievements", "LvlToAchieve", c => c.Int(nullable: false));
            DropColumn("dbo.Achievements", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Achievements", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.UserAchievements", "Achievement_AchievementId", "dbo.Achievements");
            DropForeignKey("dbo.UserAchievements", "User_UserId", "dbo.Users");
            DropIndex("dbo.UserAchievements", new[] { "Achievement_AchievementId" });
            DropIndex("dbo.UserAchievements", new[] { "User_UserId" });
            DropColumn("dbo.Achievements", "LvlToAchieve");
            DropColumn("dbo.Achievements", "XpToAchieve");
            DropTable("dbo.UserAchievements");
            CreateIndex("dbo.Achievements", "UserId");
            AddForeignKey("dbo.Achievements", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
    }
}
