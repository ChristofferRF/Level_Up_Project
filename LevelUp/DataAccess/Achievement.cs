using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccess
{
    [DataContract]
    public class Achievement
    {
        [DataMember]
        public int AchievementId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int Value { get; set; }

        [DataMember]
        public DateTime DateAchieved { get; set; }
    }
}
