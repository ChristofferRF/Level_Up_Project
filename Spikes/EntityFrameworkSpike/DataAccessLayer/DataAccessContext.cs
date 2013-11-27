using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccessLayer
{
    /// <summary>
    /// Define DbContext class, which is the link to the Entity database
    /// define the Recipe model using the DbSet property giving the model type you want to create a table from
    /// the Recipes property name is the reference to the table, which is to be used in the RecipeController
    /// side note - Install Entity Framework in all projects and define the connectionStrings in all the App.config across all projects
    /// always inherit from DbContext
    /// </summary>
    public class DataAccessContext: DbContext
    {
        public DbSet<Recipe>  Recipes { get; set; }
    }
}
