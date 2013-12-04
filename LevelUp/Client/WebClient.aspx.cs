using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace Client
{
    public partial class WebClient : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowText();
        }

        private void ShowText()
        {
            ExcerciseLabel.Text = StringValues.EXCERCISELABEL;
            DistanceLabel.Text = StringValues.DISTANCELABEL;
            TimeLabel.Text = StringValues.TIMELABEL;
            CreateLogButton.Text = StringValues.CREATELOGBUTTON;
        }

        protected void CreateLog_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("succes you pushed the button");
        }
    }
}