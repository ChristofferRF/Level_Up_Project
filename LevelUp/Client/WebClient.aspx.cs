using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using DataAccess;
using Client.App_Code;

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
            ExcerciseLabel.Text = StringValues.EXCERCISE_LABEL;
            DistanceLabel.Text = StringValues.DISTANCE_LABEL;
            TimeLabel.Text = StringValues.TIME_LABEL;
            CreateLogButton.Text = StringValues.CREATE_LOG_BUTTON;
        }

        protected void CreateLog_Click(object sender, EventArgs e)
        {
            LogEntry log = new LogEntry();
            log.LogEntryId = 0;
            log.TypeOfExcercise = excerciseTextBox.Text;
            log.Distance = distanceTextBox.Text;
            log.Minutes = Convert.ToInt32(MinutesTextBox.Text);

            log = EntryCalls.AddLogEntry(log);
            UpdateFields(log);
            Debug.WriteLine("succes you pushed the button");
        }

        private void UpdateFields(LogEntry log)
        {
            excerciseTextBox.Text = log.TypeOfExcercise;
            distanceTextBox.Text = log.Distance;
            MinutesTextBox.Text = log.Minutes.ToString();
            HoursTextBox.Text = "Grand succes!";
        }
    }
}