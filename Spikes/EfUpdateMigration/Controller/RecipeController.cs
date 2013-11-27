using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.Entity;

namespace Controller
{
    /// side note - Install Entity Framework in all projects and define the connectionStrings in all the App.config across all projects
    public class RecipeController
    {
        public RecipeController()
        {

        }

        // different input for the method as we need to add an ingredient to the recipe
        public void AddRecipeToDb(string title, string description, string ingredient, string unit, int amount)
        {
            //using statement to reference and access the database
            //using will dro the connection after use
            using (var db = new DataAccessContext())
            {
                Recipe rec = new Recipe
                {
                    Title = title,
                    Description = description,

                    //this is one way to add an object reference with one to many relationship
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient {Name = ingredient, Unit = unit, Amount = amount }
                    }
                };

                db.Recipes.Add(rec); //Add content to the database
                db.SaveChanges();//Save the changes
            }

        }
    }
}
