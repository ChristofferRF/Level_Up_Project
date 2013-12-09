using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccess
{
    [DataContract]
    public class Title
    {
        [DataMember]
        public int TitleId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public DateTime DateAchieved { get; set; }

        [DataMember]
        public int UserId { get; set; }
    }
}
