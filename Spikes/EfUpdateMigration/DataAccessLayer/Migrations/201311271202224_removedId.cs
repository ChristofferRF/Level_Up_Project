namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ingredients", "Rec_ingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ingredients", "Rec_ingId", c => c.Int(nullable: false));
        }
    }
}
