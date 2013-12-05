﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using Client.App_Code;
using System.Text.RegularExpressions;

namespace Client
{
    public partial class LoginClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if ((IsValidUserName(txtBoxUsername.Text)) && (txtBoxPassword.Text != null))
            {
                User user = new User();
                user.Name = "Ronnie";
                user.Password = "meh";
                user.Username = "Kielgasten";
                user.Weight = 85;
                user.Height = 170;

                user = UserCalls.AddUser(user);
                txtBoxUsername.Text = user.Name;
            }
            else
            {
                string display = "Fejl i Input";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
            }
        }

        public static bool IsValidUserName(string usernameString)
        {
            string usernamePattern = @"^[a-zA-Z0-9][-\w.]{0,22}([a-zA-Z\d0-9]|(?<![-.])_)$";
            return Regex.IsMatch(usernameString, usernamePattern);
        }

        public static bool IsValidEmail(string emailString)
        {
            string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(emailString, emailPattern);
        }
    }
}