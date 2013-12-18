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

            /*using (var db = new DataAccessContext())
            {
                Achievement dbItem = (from achievements in db.Achievements
                                      where achievements.UserId == userId
                                      orderby achievements.AchievementId descending
                                      select achievements).LastOrDefault();

                latestAch = dbItem;
            }*/
            return latestAch;
        }


    }
}
