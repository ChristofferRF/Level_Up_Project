using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccess
{
    [DataContract]
    public class LogEntry
    {
        [DataMember]
        public int LogEntryId { get; set; }
        [DataMember]
        public string TypeOfExcercise { get; set; }
        [DataMember]
        public string Distance { get; set; }
        [DataMember]
        public int Hours { get; set; }
        [DataMember]
        public int Minutes { get; set; }
        [DataMember]
        public int Seconds { get; set; }
        [DataMember]
        public string Date { get; set; }
        [DataMember]
        public long Kcal { get; set; }
        [DataMember]
        public int UserId { get; set; }

    }
}
