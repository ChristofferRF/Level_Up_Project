using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace RESTtest
{
    [AspNetCompatibilityRequirements
    (RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PersonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PersonService.svc or PersonService.svc.cs at the Solution Explorer and start debugging.
    public class PersonService : IPersonService
    {
        /// <summary>
        /// testmetode til XML, returnerer en streng
        /// </summary>
        /// <param name="id">whatever</param>
        /// <returns>teststring</returns>
        public string GetXmlString(string id)
        {
            return "XML personid:  " + id;
        }

        /// <summary>
        /// testmetode til JSON, returner en streng
        /// </summary>
        /// <param name="id">whatever</param>
        /// <returns>teststring</returns>
        public string GetJSONString(string id)
        {
            return "JSON personid " + id;
        }


        /// <summary>
        /// Returnerer et person-objekt
        /// </summary>
        /// <returns>person objekt</returns>
        public PersonModel GetPerson()
        {
            PersonModel pm = new PersonModel();
            return pm;
        }


        /// <summary>
        /// Opdaterer en persons navn
        /// </summary>
        /// <param name="name">Det nye navn på personen</param>
        /// <returns>Den opdaterede person</returns>
        public PersonModel UpdatePerson(string name)
        {
            PersonModel pm = new PersonModel();
            pm.Name = name;
            return pm;
        }
 

        /// <summary>
        /// Opret en ny person med navn og id.
        /// </summary>
        /// <param name="name">personens navn</param>
        /// <param name="age">personens alder</param>
        /// <returns>Den nye person</returns>
        public PersonModel CreatePerson(string name, int age)
        {
            PersonModel pm = new PersonModel();
            pm.Name = name;
            pm.Age = age;
            return pm;

        }

        /// <summary>
        /// Vi skal ikke bruge XML til dette projekt, 
        /// men her er en demo af hvordan man serialiserer et objekt 
        /// til XML.. Just in case
        /// </summary>
        /// <returns></returns>
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

    }
}