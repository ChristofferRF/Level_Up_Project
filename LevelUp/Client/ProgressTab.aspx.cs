using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Client
{
    public partial class ProgressTab : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowText();
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

            level.Text = StringValues.LEVEL_LABEL;
            title.Text = StringValues.TITLE_LABEL;

            latestEntry.Text = StringValues.LATESTENTRY_LABEL;
            latestAch.Text = StringValues.LATESTACHIEVEMENT_LABEL;
        }

    }
}