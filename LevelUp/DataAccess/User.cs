﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccess
{
    [KnownType(typeof(List<LogEntry>))]
    [KnownType(typeof(List<Achievement>))]
    [KnownType(typeof(List<Title>))]
    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string UserName { get; set; }

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

        //Privacy attributes
        [DataMember]
        public string PrivacyName { get; set; }

        [DataMember]
        public string PrivacyAge { get; set; }

        [DataMember]
        public string PrivacyWeight { get; set; } 

        [DataMember]
        public string PrivacyHeight { get; set; }
    }
}
