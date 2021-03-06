﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DataAccess;
using Controller;
using System.Globalization;
using System.Diagnostics;

namespace RESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LevelService : ILog, IUser, IAchievement
    {
        public LogEntryController logCon = new LogEntryController();
        public UserController userCon = new UserController();
        /// <summary>
        /// Kalder add entry controlleren.
        /// Bemærk konverteringen fra string minutes til int.
        /// {"Distance":"50","LogEntryId":0,"Minutes":50,"TypeOfExcercise":"bike"}
        /// </summary>
        /// <param name="typeOfExercise"></param>
        /// <param name="distance"></param>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public LogEntry AddEntry(string distance, string logEntryId, string hours, string minutes, string seconds, string typeOfExcercise, string userId, string dateCreated, string kcal)
        {
            return logCon.AddEntryToDb(typeOfExcercise, distance, Convert.ToInt32(hours), Convert.ToInt32(minutes), Convert.ToInt32(seconds), Convert.ToInt32(userId), dateCreated, Convert.ToInt64(kcal));
        }

        /// <summary>
        /// Kalder add user controlleren
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public User AddUser(string age, string height, string name, string password, string userId, string userName, string weight, string xp, string level, string privacyName, string privacyAge, string privacyHeight, string privacyWeight)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            return userCon.AddUserToDb(userName, password, name, Convert.ToInt32(age), Convert.ToDouble(weight, nfi), Convert.ToDouble(height, nfi), Convert.ToInt64(xp), Convert.ToInt32(level), privacyName, privacyAge, privacyHeight, privacyWeight);
        }


        public User GetUser(string userName, string password)
        {
            return  userCon.GetUser(userName, password);
        }

        /// <summary>
        /// Kalder updateUser controlleren
        /// </summary>
        /// <param name="age"></param>
        /// <param name="height"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <param name="weight"></param>
        /// <param name="xp"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public User UpdateUser(string UserName, string Password, string Name, string Age, string Weight, string Height, string Xp, string Level)
        {                     
            return userCon.UpdateUserProfile(UserName, Password, Name, Convert.ToInt32(Age), Convert.ToDouble(Weight, CultureInfo.CurrentCulture), Convert.ToDouble(Height, CultureInfo.CurrentCulture), Convert.ToInt64(Xp), Convert.ToInt32(Level));
        }

        /// <summary>
        /// kalder metode på UserControlleren som henter brugerens seneste 5 logs ud fra UserId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<LogEntry> GetFiveLatestLogs(string userId)
        {
            return userCon.GetFiveLatestLogs(Convert.ToInt32(userId));
        }


        /// Indsæt optjent xp på brugeren.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="earnedXp"></param>
        public void UpdateUserXp(string userName, string earnedXp)
        {
            userCon.UpdateUserXP(userName, Convert.ToInt64(earnedXp));
        }



        public Achievement GetLatestAchievement(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
