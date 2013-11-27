using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace Client
{
    /// side note - Install Entity Framework in all projects and define the connectionStrings in all the App.config across all projects
    public partial class Form1 : Form
    {
        //reference to the RecipeController
        public RecipeController RecCtr { get; set; }
        public Form1()
        {
            InitializeComponent();
            RecCtr = new RecipeController();
            //create new instance of the RecipeController
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string description = textBoxDescription.Text;

            string ingredient = textBoxIngredient.Text;
            string unit = textBoxUnit.Text;
            int amount = Convert.ToInt32(textBoxAmount.Text);

            RecCtr.AddRecipeToDb(title, description, ingredient, unit, amount);
            //use the controller objects method AddRecipe and fill in the inputs
        }
    }
}
