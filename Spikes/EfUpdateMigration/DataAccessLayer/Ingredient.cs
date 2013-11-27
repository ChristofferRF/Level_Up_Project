using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// The new class which we want to add as a list of ingredients on the recipe
    /// first define the class with all the neccesary properties
    /// to add the foreign key simply use object reference with virtual type
    /// to Enable migrations in the project. click TOOLS -> Library package manager -> Package manager console
    /// in the console window select the DataAccesLayer and set the DataAccessLayer as startup project
    /// now type Enable-Migrations and hit enter
    /// type Add-Migration and hit enter. The console will prompt for a name for the migration, give it a descriptive name
    /// after the migration is added(you can see it in the migrations folder) type Update-Database
    /// and magic will happen. for real, trust me on this one.
    /// </summary>appen
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Amount { get; set; }

        public virtual Recipe recipe { get; set; }
    }
}
