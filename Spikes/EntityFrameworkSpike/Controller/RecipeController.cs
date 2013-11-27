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

        public void AddRecipeToDb(string title, string description)
        {
            //using statement to reference and access the database
            //using will dro the connection after use
            using (var db = new DataAccessContext())
            {
                Recipe rec = new Recipe
                {
                    Title = title,
                    Description = description,
                };

                db.Recipes.Add(rec); //Add content to the database
                db.SaveChanges();//Save the changes
            }

        }
    }
}
