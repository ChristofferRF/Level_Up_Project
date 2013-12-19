using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.Entity;
using System.Diagnostics;

namespace Controller
{
    public class AchievementController
    {
        public AchievementController()
        {

        }

        public Achievement GetLatestAchievement(int userId)
        {
            //By userID, find latest achievement and send to client
            Achievement latestAch = new Achievement();

            using (var db = new DataAccessContext())
            {
                var query = "select * from achievements as a where achievementid ="+
                            "(select achievement_achievementid from userachievements "+
                            "where  user_userid = 57 and achievement_achievementid = a.achievementid)";

                var data = db.Database.SqlQuery<Achievement>(query).First();
                latestAch = data;
            }
            return latestAch;
        }


    }
}
