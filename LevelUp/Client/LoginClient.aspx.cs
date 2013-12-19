using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using Client.App_Code;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;

namespace Client
{
    public partial class LoginClient : System.Web.UI.Page
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
            lblUsername.Text = StringValues.LBL_USERNAME;
            lblPassword.Text = StringValues.LBL_PASSWORD;
            btnCreateUser.Text = StringValues.BTN_CREATE_USER;
            btnLogin.Text = StringValues.BTN_LOGIN;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if ((IsValidUserName(txtBoxUsername.Text)) && (txtBoxPassword.Text != null))
            {
                try
                {
                    User u = null;
                    u = UserCalls.GetUser(txtBoxUsername.Text, Security.HashMe(txtBoxPassword.Text));
                    if (u.UserName != null)
                    {
                        Session["UserItem"] = u;
                        Response.Redirect("ProgressTab.aspx");
                    }
                    else
                    {
                        string display = "Bruger ikke fundet";
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.StackTrace);
                }
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

        protected void btnCreateUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateUser.aspx");
        }
    }
}