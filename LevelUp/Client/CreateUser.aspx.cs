using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using DataAccess;
using Client.App_Code;
using System.Text.RegularExpressions;

namespace Client
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            if (IsValidUserName(selectedUsername.Text) &&
                IsValidName(userName.Text) &&
                IsValidAge(userAge.Text) &&
                IsValidHeight(userHeight.Text) &&
                IsValidWeight(userWeight.Text))
            {
                User user = new User();
                user.Username = selectedUsername.Text;
                user.Name = userName.Text;
                user.Age = Convert.ToInt32(userAge.Text);
                user.Height = Convert.ToDouble(userHeight.Text);
                user.Weight = Convert.ToDouble(userWeight.Text);

                user = UserCalls.AddUser(user);
                Debug.WriteLine("User has sucessfully been created in the database");
            }
            else
            {
                // Pop up some dialog + accumulate error message
                string display = "Fejl i Input";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
            }
        }




        //RegEx input sanitation
        public static bool IsValidUserName(string usernameString)
        {
            string usernamePattern = @"^[a-zA-Z0-9][-\w.]{0,22}([a-zA-Z\d0-9]|(?<![-.])_)$";
            return Regex.IsMatch(usernameString, usernamePattern);
        }

        public static bool IsValidName(string nameString)
        {
            string namePattern = @"^[a-zæøåA-ZÆØÅ ]*$";
            return Regex.IsMatch(nameString, namePattern);
        }

        public static bool IsValidAge(string ageString)
        {
            if (Convert.ToInt32(ageString) >= 12)
            {
                string agePattern = @"^[0-9]{1,3}$";
                return Regex.IsMatch(ageString, agePattern);
            }
            else
                return false;
        }

        public static bool IsValidHeight(string heightString)
        {
            string heightPattern = @"^-?[0-9]{0,4}([/./,][0-9]{1,3})$";
            return Regex.IsMatch(heightString, heightPattern);
        }

        public static bool IsValidWeight(string WeightString)
        {
            string WeightPattern = @"^-?[0-9]{0,4}([/./,][0-9]{1,3})$";
            return Regex.IsMatch(WeightString, WeightPattern);
        }
    }
}