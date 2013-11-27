using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// Define model class with neccesary properties nothing new here
    /// </summary>
    public class Recipe
    {
        //the primary key is RecipeId, Id is the identifier for Entity to recognize and is not case sensitive
        //Note Recipe_id does not work
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual List<Ingredient> Ingredients { get; set; }
    }
}
