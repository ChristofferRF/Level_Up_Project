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
    public class LevelService : ILog
    {
        public LogEntryController logCon = new LogEntryController();

        /// <summary>
        /// Kalder add entry controlleren.
        /// Bemærk conversionen fra string minutes til int.
        /// {"Distance":"50","LogEntryId":0,"Minutes":50,"TypeOfExcercise":"bike"}
        /// </summary>
        /// <param name="typeOfExercise"></param>
        /// <param name="distance"></param>
        /// <param name="minutes"></param>
        /// <returns></returns>
        public LogEntry AddEntry(string distance, string logEntryId, string minutes, string typeOfExcercise)
        {
           return logCon.AddEntryToDb(typeOfExcercise, distance, Convert.ToInt32(minutes));
        }
    }
}
