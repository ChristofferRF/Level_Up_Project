using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DataAccess;
using Controller;

namespace RESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LevelService : ILog, IUser
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
        public LogEntry AddEntry(string distance, string logEntryId, string hours, string minutes, string seconds, string typeOfExcercise)
        {
            return logCon.AddEntryToDb(typeOfExcercise, distance, Convert.ToInt32(hours), Convert.ToInt32(minutes), Convert.ToInt32(seconds));
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
        public User AddUser(string age, string height, string name, string password, string userId, string userName, string weight, string xp, string level)
        {
            return userCon.AddUserToDb(userName, password, name, Convert.ToInt32(age), Convert.ToDouble(weight), Convert.ToDouble(height), Convert.ToInt64(xp), Convert.ToInt32(level));
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
        public User UpdateUser(string userName, string passWord, string name, int age, double weight, double height, long xp, int level)
        {
            // string userName, string passWord, string name, int age, double weight, double height, long xp, int level
            return userCon.updateUserProfile(userName, passWord, name, age, weight, height, xp, level);
        }
    }
}