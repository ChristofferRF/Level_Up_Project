namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedIngredients : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        IngredientId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Unit = c.String(),
                        Amount = c.Int(nullable: false),
                        Rec_ingId = c.Int(nullable: false),
                        recipe_RecipeId = c.Int(),
                    })
                .PrimaryKey(t => t.IngredientId)
                .ForeignKey("dbo.Recipes", t => t.recipe_RecipeId)
                .Index(t => t.recipe_RecipeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ingredients", "recipe_RecipeId", "dbo.Recipes");
            DropIndex("dbo.Ingredients", new[] { "recipe_RecipeId" });
            DropTable("dbo.Ingredients");
        }
    }
}
