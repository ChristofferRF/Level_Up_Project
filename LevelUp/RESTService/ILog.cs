using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DataAccess;

namespace RESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILog
    {

        [OperationContract]
        [WebInvoke(Method = "PUT", 
            ResponseFormat = WebMessageFormat.Json, 
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "levelUp/entry/add")]
        LogEntry AddEntry(string typeOfExercise, string distance, string minutes);

    }


}
