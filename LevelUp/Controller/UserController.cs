using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.Entity;

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
                               where user.Username == username & user.Password == password
                               select user).First<User>();

                //theUser.Achievements = GetUsersAchievements(theUser.UserId);
                //theUser.Titles = GetUsersTitles(theUser.UserId);

                newUser = theUser;
            }

            newUser.Achievements = GetUsersAchievements(newUser.UserId);

            newUser.Titles = GetUsersTitles(newUser.UserId);

            return newUser;
        }

        public List<Achievement> GetUsersAchievements(int userId)
        {
            List<Achievement> achList = new List<Achievement>();
            using (var db = new DataAccessContext())
            {
                List<Achievement> achievements = (from ach in db.Achievements
                                                  where ach.UserId == userId
                                                  select ach).ToList();
                achList = achievements;
            }
            return achList;
        }

        public List<Title> GetUsersTitles(int userId)
        {
            List<Title> titList = new List<Title>();
            using (var db = new DataAccessContext())
            {
                List<Title> titles = (from tit in db.Titles
                                      where tit.UserId == userId
                                      select tit).ToList();
                titList = titles;
            }
            return null;
        }
    }
}
