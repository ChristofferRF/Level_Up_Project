﻿using System;
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
    }
}
