using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccess
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public double Weight { get; set; }

        [DataMember]
        public double Height { get; set; }

        [DataMember]
        public int Level { get; set; }

        [DataMember]
        public long Xp { get; set; }

        [DataMember]
        public virtual List<LogEntry> Logs { get; set; }

        [DataMember]
        public virtual List<Achievement> Achievements { get; set; }

        [DataMember]
        public virtual List<Title> Titles { get; set; }
    }
}
