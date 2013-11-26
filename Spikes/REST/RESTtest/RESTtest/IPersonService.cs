using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web
using System.Text;
}
namespace RESTtest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPersonService" in both code and config file together.
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        [WebInvoke(Method= "GET",                       //Get-metode
                ResponseFormat= WebMessageFormat.Xml,   //Returnerer XMl format
                BodyStyle= WebMessageBodyStyle.Wrapped, //pas
                UriTemplate = "xml/{id}")]              //URI består af: En URL-sti og en query
        string XMLData(string id);                      //pas

        [OperationContract]
        [WebInvoke(Method= "GET",
            ResponseFormat = WebMessageFormat.Json,      //returnere JSON format
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/{id}")]
        string JSONData(string id);
    }
}
