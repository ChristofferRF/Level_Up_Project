using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTtest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPersonService" in both code and config file together.
    [ServiceContract]
    public interface IPersonService
    {

        //Lynhurtige testeksempler
        //Se om der er hul igennem, also, xml test
        [OperationContract]
        [WebInvoke(Method= "GET",                       //Get-metode
                ResponseFormat= WebMessageFormat.Xml,   //Returnerer XMl format
                BodyStyle= WebMessageBodyStyle.Wrapped, //ikke helt sikker, det har at gøre med hvordan beskeden formatteres. vi går ikke galt med .Wrapped
                UriTemplate = "xml/{id}")]              //URI består af: En URL-sti og en query
        string GetXmlString(string id);                 //metodekald

        [OperationContract]
        [WebInvoke(Method= "GET",
            ResponseFormat = WebMessageFormat.Json,      //returnerer JSON format
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/{id}")]
        string GetJSONString(string id);

        //Operationelle eksempler - CRUD
        //Hent et person-objekt
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "person/get")]
        PersonModel GetPerson();

        //Opdatér en eksisterendde person
        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "person/update/{name}")]
        PersonModel UpdatePerson(string name);
        
        //Opret et nyt person-objekt
        [OperationContract]
        [WebInvoke(Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "person/create/{name},{age}")]
        PersonModel CreatePerson(string name, int age);
    }
}
