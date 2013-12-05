using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.Entity;

namespace Controller
{
    public class LogEntryController
    {
        public LogEntryController()
        {
            
        }

        public LogEntry AddEntryToDb(string typeOfExcercise, string distance, int hours, int minutes, int seconds)
        {
            LogEntry demoLog = new LogEntry();
            int result = -1;
            using (var db = new DataAccessContext())
            {
                LogEntry log = new LogEntry
                {
                    TypeOfExcercise = typeOfExcercise,
                    Distance = distance,
                    Hours = hours,
                    Minutes = minutes,
                    Seconds = seconds,
                };

                db.LogEntries.Add(log);
                result = db.SaveChanges();
            }

            if (result != -1)
            {
                return demoLog;
            }
            else
            {
                return demoLog;  
            }

        }
    }
}
