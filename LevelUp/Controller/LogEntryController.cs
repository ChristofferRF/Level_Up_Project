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
    public class LogEntryController
    {
        public LogEntryController()
        {
            
        }

        public LogEntry AddEntryToDb(string typeOfExcercise, string distance, int hours, int minutes, int seconds, string dateCreated, long kcal)
        {
            Debug.WriteLine(dateCreated);
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
                    UserId = 6,
                    DateCreated = dateCreated,
                    Kcal = kcal,
                };
                demoLog = log;
                db.LogEntries.Add(log);
                result = db.SaveChanges();
            }

            if (result != -1)
            {
                return demoLog;
            }
            else
            {
                return null;
            }
        }

        public LogEntry GetEntryFromDB(int entryId, int userId)
        {
            LogEntry entry = new LogEntry();
            using (var db = new DataAccessContext()) {

                LogEntry theEntry = (from log in db.LogEntries
                                     where log.LogEntryId == entryId & log.UserId == userId
                                     select log).Single();
                entry = theEntry;
            }

            return entry;
        }
    }
}