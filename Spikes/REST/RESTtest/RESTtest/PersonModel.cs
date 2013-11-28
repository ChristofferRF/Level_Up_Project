using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTtest
{
    [DataContract]
    public class PersonModel
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }

        public PersonModel()
        {
            this.Name = "Ronnie";
            this.Age = 31;
        }
    }
}