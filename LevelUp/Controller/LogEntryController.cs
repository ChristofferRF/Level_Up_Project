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

        public void AddEntryToDb(string typeOfExcercise, string distance, int minutes)
        {
            using (var db = new DataAccessContext())
            {
                LogEntry log = new LogEntry
                {
                    TypeOfExcercise = typeOfExcercise,
                    Distance = distance,
                    Minutes = minutes,
                };

                db.LogEntries.Add(log);
                db.SaveChanges();
            }
        }
    }
}
