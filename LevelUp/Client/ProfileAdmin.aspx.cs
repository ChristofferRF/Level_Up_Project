using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using System.Diagnostics;
using Client.App_Code;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Client
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                ShowText();
                DisplayUserData();
            }
        }

        private void ShowText()
        {
            userInfoName.Text = StringValues.USERINFONAME_LABEL;
            userInfoAge.Text = StringValues.USERINFOAGE_LABEL;
            userInfoHeight.Text = StringValues.USERINFOHEIGHT_LABEL;
            userInfoWeight.Text = StringValues.USERINFOWEIGHT_LABEL;

            navProgress.Text = StringValues.NAMEPROGRESS_LABEL;
            navEntry.Text = StringValues.ENTRIES_LABEL;
            navAch.Text = StringValues.ACHIEVEMENTS_LABEL;
            navStatistics.Text = StringValues.STATISTICS_LABEL;
        }

        private void DisplayUserData()
        {
            User user = (User)Session["UserItem"];
            if (user == null)
            {
                Response.Redirect("LoginClient.aspx");
            }
            else
            {
                User u = (User)Session["UserItem"];
                AdmNameLbl.Text = u.Name;
                AdmAgeLbl.Text = u.Age.ToString();
                AdmHeightLbl.Text = u.Height.ToString();
                AdmWeightLbl.Text = u.Weight.ToString();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            User user = (User)Session["UserItem"];
            if (txtBoxPW2.Text == txtBoxPW3.Text)
            {
                user.Password = txtBoxPW2.Text;
                user = UserCalls.UpdateUser(user);
            }
            else
            {
                // Pop up some dialog + accumulate error message
                string display = "Fejl i Input";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
            }
        }

        protected void btnUpdateUser_Click(object sender, EventArgs e)
        {

        }
    }
}