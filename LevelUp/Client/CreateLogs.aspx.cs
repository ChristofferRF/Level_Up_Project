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
    public partial class CreateLogs : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowText();
            BindGrid();
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

            ExcerciseLabel.Text = StringValues.EXCERCISE_LABEL;
            DistanceLabel.Text = StringValues.DISTANCE_LABEL;
            TimeLabel.Text = StringValues.TIME_LABEL;
            CreateLogButton.Text = StringValues.CREATE_LOG_BUTTON;
            RewardsLabel.Text = StringValues.REWARDS_LABEL;
            LogsLabel.Text = StringValues.LOGS_LABEL;

            //tableDate.Text = StringValues.TABLEDATE_LABEL;
            //tableActivity.Text = StringValues.TABLEACTIVITY_LABEL;
            //tableDistance.Text = StringValues.TABLEDISTANCE_LABEL;
            //tableTime.Text = StringValues.TABLETIME_LABEL;
            
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
                log.DateCreated = DateTime.Today.ToShortDateString();

                int minutes = CalculateMinutes(Convert.ToInt32(HoursTextBox.Text), Convert.ToInt32(MinutesTextBox.Text), Convert.ToInt32(SecondsTextBox.Text));
                log.Kcal = CalculateKcal(excerciseTextBox.Text, minutes, 100); 

                log = EntryCalls.AddLogEntry(log);

                User u = UserCalls.GetUser("Kielgasten", "meh");

                UserCalls.UpdateUserXP(u.Username, log.Kcal);
                u = UserCalls.GetUser(u.Username, u.Password);

                UpdateFields(log);
                ShowRewardsOutput(u, log);
                BindGrid(); // bind the gridView again after log is added to DB
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

        public void ShowRewardsOutput(User u, LogEntry log)
        {
            
            string achievementName = "Collector";
            string achFlavourText = "Bedrift for at oprette din første træning";

            RewardOutput.Text += StringValues.REWARDS_TITLE;
            RewardOutput.Text += "\n";
            RewardOutput.Text += " Du har i alt "+ u.Xp + " XP";
            RewardOutput.Text += "\n";
            RewardOutput.Text += " Du har forbrændt " + log.Kcal + " KCAL på denne træning";
            RewardOutput.Text += "\n";
            RewardOutput.Text += StringValues.ACHIEVEMENT_TITLE;
            RewardOutput.Text += "\n";
            RewardOutput.Text += "  - " + achievementName;
            RewardOutput.Text += "\n";
            RewardOutput.Text += "  - " + achFlavourText;
        }

        public void ShowLogEntries()
        {
            //Listview
            //This method should load all the users logs when 
        }

        public void ShowNewLogInList()
        {
            //default data for testpurposes
            LogEntry log = new LogEntry();
            log.TypeOfExcercise = "bike";
            log.Distance = "50km";
            log.Hours = 0;
            log.Minutes = 50;
            log.Seconds = 0;

            //ListViewItem item = new ListViewItem();
            //LogsListView.Items.
                
        }

        public void BindGrid()
        {
            List<LogEntry> list = new List<LogEntry>();
            int userId = 6;
            list = UserCalls.GetFiveLatestLogs(userId);


            this.gvLogs.DataSource = list;
            this.gvLogs.DataBind();
        }

        private int CalculateMinutes(int hours, int minuttes, int seconds)
        {
            int allTheMinutes = 0;
            allTheMinutes += hours * 60;
            allTheMinutes += minuttes;
            allTheMinutes += seconds / 60;
            return allTheMinutes;
        }

        public long CalculateKcal(string typeOfExercise, int minutes, double bodyWeight)
        {
            double burnRunning = 0.82;
            double burnBike = 0.38;
            double activeBurn = 0;
            double burnedBabyBurned = 0;
            if (typeOfExercise == "Running")
            {
                activeBurn = burnRunning;
            }
            else if (typeOfExercise == "Bike")
            {
                activeBurn = burnBike;
            }
            else
            {
                activeBurn = 0.10;
            }

            burnedBabyBurned = activeBurn * bodyWeight * minutes;
            
            return Convert.ToInt64(burnedBabyBurned);
        }
    }
}