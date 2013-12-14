using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using DataAccess;

namespace RESTService
{
    [ServiceContract]
    interface IUser
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "add")]
        User AddUser(string Age, string Height, string Name, string Password, string UserId, string Username, string Weight, string XP, string Level);

        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "get")]
        User GetUser(string UserName, string Password);

        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "update")]
        User UpdateUser(string userName, string passWord, string name, string age, string weight, string height, string xp, string level); //Virker ikke pga. lowercase. Det skal matche property-navnet 100%

        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "get/logs")]
        List<LogEntry> GetFiveLatestLogs(string UserId);

        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "update/xp")]
        void UpdateUserXp(string UserName, string EarnedXp);
    }
}