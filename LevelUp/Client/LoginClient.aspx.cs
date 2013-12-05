using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using Client.App_Code;

namespace Client
{
    public partial class LoginClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
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
    }
}