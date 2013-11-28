using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace RESTtest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PersonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PersonService.svc or PersonService.svc.cs at the Solution Explorer and start debugging.
    public class PersonService : IPersonService
    {
        public string XMLData(string id)
        {
            return "XML personid:  " + id;
        }

        public string JSONData(string id)
        {
            return "JSON personid " + id;
        }

        public string XMLPersonObject()
        {
            XmlSerializer xs = new XmlSerializer(typeof(PersonModel));
            var obj = new PersonModel();
            StringWriter sw = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sw);
            xs.Serialize(writer, obj);
            string xml = sw.ToString();
            return xml;
        }

        public PersonModel JSONPersonObject()
        {
            PersonModel pm = new PersonModel();
            return pm;
        }

        public PersonModel JSONPostObject(string name)
        {
            PersonModel pm = new PersonModel();
            pm.Name = name;
            return pm;
        }
        public string XMLUpdatePerson(string name)
        {
            XmlSerializer xs = new XmlSerializer(typeof(PersonModel));
            var obj = new PersonModel();
            obj.Name = name;
            StringWriter sw = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sw);
            xs.Serialize(writer, obj);
            string xml = sw.ToString();
            return xml;
        }

        public PersonModel JSONPutObject(string name, int age)
        {
            PersonModel pm = new PersonModel();
            pm.Name = name;
            pm.Age = age;
            return pm;
            return pm;
        }
    }
}