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
            // Log entry bør altid opdatere en user
            // kald metoder der opdaterer user i usercontroller

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
                };

                db.LogEntries.Add(log);
                result = db.SaveChanges();
            }

            if (result != 1)
            {
                return demoLog;
            }
            else
            {
                return demoLog;
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