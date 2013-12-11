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
            RewardsLabel.Text = StringValues.REWARDS_LABEL;
            LogsLabel.Text = StringValues.LOGS_LABEL;
        }

        protected void CreateLog_Click(object sender, EventArgs e)
        {
            if (IsValidActitity(excerciseTextBox.Text) &&
                IsValidDistance(distanceTextBox.Text) &&
                IsvalidTime(HoursTextBox.Text) &&
                IsvalidTime(MinutesTextBox.Text) &&
                IsvalidTime(SecondsTextBox.Text))
            {
                LogEntry log = new LogEntry();
                log.LogEntryId = 0;
                log.TypeOfExcercise = excerciseTextBox.Text;
                log.Distance = distanceTextBox.Text;
                log.Hours = Convert.ToInt32(HoursTextBox.Text);
                log.Minutes = Convert.ToInt32(MinutesTextBox.Text);
                log.Seconds = Convert.ToInt32(SecondsTextBox.Text);

                log = EntryCalls.AddLogEntry(log);
                UpdateFields(log);
                TestRewardsOutput();
                Debug.WriteLine("succes you pushed the button");
            }
            else
            {
                // Pop up some dialog + accumulate error message
                string display = "Fejl i Input";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
            }
            
        }

        private void UpdateFields(LogEntry log)
        {
            excerciseTextBox.Text = log.TypeOfExcercise;
            distanceTextBox.Text = log.Distance;
            MinutesTextBox.Text = log.Minutes.ToString();
            HoursTextBox.Text = log.Hours.ToString();
            SecondsTextBox.Text = log.Seconds.ToString();
        }

        // Check for valid time input
        public static bool IsvalidTime(string timeString)
        {
            if (timeString.Length < 3)
            {
                string intPattern = @"^[0-9]{0,2}$";
                return Regex.IsMatch(timeString, intPattern);
            }
            else
            {
                return false;
            }
        }

        // Check for valid distance input
        public static bool IsValidDistance(string distanceString)
        {
            string distancePattern = @"^-?[0-9]{0,4}([/./,][0-9]{1,3})$";
            return Regex.IsMatch(distanceString, distancePattern);
        }

        // Check for valid input for activity
        public static bool IsValidActitity(string activityString)
        {
            string activityPattern = @"^[a-zæøåA-ZÆØÅ ]*$";
            return Regex.IsMatch(activityString, activityPattern);
        }

        public void TestRewardsOutput()
        {
            
            string xp = "100 Xp";
            string cal = "350 Kcal";
            string achievementName = "Collector";
            string achFlavourText = "Bedrift for at oprette din første træning";

            RewardOutput.Text += StringValues.REWARDS_TITLE;
            RewardOutput.Text += "\n";
            RewardOutput.Text += "  - "+xp;
            RewardOutput.Text += "\n";
            RewardOutput.Text += "  - " + cal;
            RewardOutput.Text += "\n";
            RewardOutput.Text += StringValues.ACHIEVEMENT_TITLE;
            RewardOutput.Text += "\n";
            RewardOutput.Text += "  - " + achievementName;
            RewardOutput.Text += "\n";
            RewardOutput.Text += "  - " + achFlavourText;
        }
    }
}