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
using System.Globalization;

namespace Client
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                ShowText();
            }
        }

        private void ShowText()
        {
            lblSelectedUsername.Text = StringValues.LBL_SELECTED_USERNAME;
            lblSelectedPassword.Text = StringValues.LBL_SELECTED_PASSWORD;
            lblConfirmPassword.Text = StringValues.LBL_CONFIRM_PASSWORD;
            // - lower part of form -
            lblUsername.Text = StringValues.LBL_USERNAME_CREATE;
            lblUserage.Text = StringValues.LBL_USERAGE_CREATE;
            lblUserheight.Text = StringValues.LBL_USERHEIGHT_CREATE;
            lblUserweight.Text = StringValues.LBL_USERWEIGHT_CREATE;
            createUserButton.Text = StringValues.BTN_USER_CREATE;
        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            


            if (IsValidUserName(selectedUsername.Text) &&
                IsValidName(userName.Text) &&
                IsValidAge(userAge.Text) &&
                IsValidHeight(userHeight.Text) &&
                IsValidWeight(userWeight.Text))
            {
                Debug.WriteLine(CultureInfo.CurrentCulture.ToString());
                User user = new User();
                user.Username = selectedUsername.Text;
                user.Password = selectedPassword.Text;
                user.Name = userName.Text;
                user.Age = Convert.ToInt32(userAge.Text);
                user.Height = Convert.ToDouble(userHeight.Text, CultureInfo.CurrentCulture);
                user.Weight = Convert.ToDouble(userWeight.Text, CultureInfo.CurrentCulture);
                user.Xp = 0;
                user.Level = 1;
                user.PrivacyName = "none";
                user.PrivacyAge = "none";
                user.PrivacyHeight = "none";
                user.PrivacyWeight = "none";

                user = UserCalls.AddUser(user);
                if (user.Username != null)
                { 
                    Session["UserItem"] = user;
                    Response.Redirect("ProgressTab.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Null bruger');", true);
                }
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