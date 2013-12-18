using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;

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
            // Pseudo object
            string userName = "Kielgasten";
            string password = "meh";
            string name = "Ronnie";
            int age = 0;
            double weight = 85.0;
            double height = 170.0;
            long xp = 2795;
            int level = 4;
            // kald servicen 
            // --> send on button click to controller.updateUser();
            /*
             string username, string password, string name, int age, double weight, double height, long xp, int level
             */
        }
    }
}