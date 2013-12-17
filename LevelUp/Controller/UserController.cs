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
    public class UserController
    {
        public UserController()
        {

        }

        public User AddUserToDb(string username, string password, string name, int age, double weight, double height, long xp, int level)
        {
            User demoUser = new User();
            int result = -1;

            using (var db = new DataAccessContext())
            {
                User user = new User
                {
                    Username = username,
                    Password = password,
                    Name = name,
                    Age = age,
                    Weight = weight,
                    Height = height,
                    Xp = xp,
                    Level = level
                };

                db.Users.Add(user);
                result = db.SaveChanges();
            }

            if (result != -1)
                return demoUser;
            else
                return demoUser;
        }
        public User GetUser(string username, string password)
        {
            User newUser = new User();
            using (var db = new DataAccessContext())
            {
                User theUser = (from user in db.Users
                                    .Include("Achievements")
                                    .Include("Titles")
                                    .Include("Logs")
                                where user.Username == username & user.Password == password
                                select user).FirstOrDefault();

                //List<Achievement> achievements = (from ach in db.Achievements
                //                                  where ach.UserId == theUser.UserId
                //                                  select ach).ToList();

                //List<Title> titles = (from tit in db.Titles
                //                      where tit.UserId == theUser.UserId
                //                      select tit).ToList();

                //List<LogEntry> logs = (from log in db.LogEntries
                //                       where log.UserId == theUser.UserId
                //                       select log).ToList();
                //theUser.Achievements = achievements;
                //theUser.Titles = titles;
                //theUser.Logs = logs;
                newUser = theUser;
            }
            
            return newUser;
        }

        public void UpdateUserXP(string userName, long earnedXp)
        {

            bool sendForAchievement = false; 
            User newUser = new User();
            long oldXp;

            using (var db = new DataAccessContext())
            {
                User theUser = (from user in db.Users
                                where user.Username == userName
                                select user).FirstOrDefault();

                // Get the old xp for user before accumulating
                oldXp = theUser.Xp;

                // Accumulate new xp
                theUser.Xp += earnedXp;
 
                // Check for LevelUp
                long newXp = theUser.Xp;

                // Check if User should be levelled up
                if ((newXp) > (oldXp * 1.1))
                {
                    // Increment user level
                    theUser.Level += 1;
                }
                
                newUser = theUser;

                db.SaveChanges();
            }

             AssignAchievement(CheckForAchievement(newUser.Xp), newUser);


        }


        public User UpdateUserProfile(string userName, string password, string name, int age, double weight, double height, long xp, int level)
        {
            User newUser = new User();

            using (var db = new DataAccessContext())
            {
                User theUser = (from user in db.Users
                                where user.Username == name
                                select user).FirstOrDefault();

                // Update user
                theUser.Username = userName;
                theUser.Password = password;
                theUser.Name = name;
                theUser.Age = age;
                theUser.Weight = weight;
                theUser.Height = height;
                theUser.Xp = xp;
                theUser.Level = level;

                newUser = theUser;

                db.SaveChanges();
            }

            return newUser;
        }

        public List<LogEntry> GetFiveLatestLogs(int userId)
        {
            List<LogEntry> lastFiveLogs = new List<LogEntry>();
            using (var db = new DataAccessContext())
            {
                List<LogEntry> dbList = (from logs in db.LogEntries
                                         where logs.UserId == userId
                                         orderby logs.LogEntryId descending
                                         select logs).Take(5).ToList();
                lastFiveLogs = dbList;
            }
            return lastFiveLogs;
        }


        /// <summary>
        /// Baseret på brugerens xp, check om der er nogle achievement som kan tildeles.
        /// 
        /// </summary>
        /// <param name="userXp"></param>
        /// <returns>liste over evt. achieves som brugeren skal have</returns>
        private List<Achievement> CheckForAchievement(long userXp)
        {
            List<Achievement> eligebleAchieves = new List<Achievement>();
            List<Achievement> allTheAchieves = new List<Achievement>();
            using (var db = new DataAccessContext())
            {
                List<Achievement> dbList = (from achievements in db.Achievements select achievements).ToList();
                allTheAchieves = dbList;
            }
                foreach (Achievement ach in allTheAchieves)
                {
                    if (userXp > ach.XpToAchieve && ach.XpToAchieve != -1)
                    {
                        eligebleAchieves.Add(ach);
                    }
                }
            
            return eligebleAchieves;
        }


        /// <summary>
        /// Tildeler de achievements til brugeren, som er fundet.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="currentUser"></param>
        private void AssignAchievement(List<Achievement> list, User currentUser)
        {
            
            using (var db = new DataAccessContext())
            {
                User dbUser = (from user in db.Users
                                where user.UserId == currentUser.UserId
                                select user).FirstOrDefault();

                dbUser.Achievements = list;

                db.SaveChanges();
            }

        }
    }
}