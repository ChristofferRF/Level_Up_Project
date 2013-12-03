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

        public int AddEntryToDb(string typeOfExcercise, string distance, int minutes)
        {
            int result = -1;
            using (var db = new DataAccessContext())
            {
                LogEntry log = new LogEntry
                {
                    TypeOfExcercise = typeOfExcercise,
                    Distance = distance,
                    Minutes = minutes,
                };

                db.LogEntries.Add(log);
                result = db.SaveChanges();
            }

            return result;
        }
    }
}
