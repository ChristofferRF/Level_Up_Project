using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using RESTtest;
namespace RESTClient
{
    public partial class client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            test();
            //test2();
        }


        private void test()
        {

            try
            {

                string name = "joe";
                string jsonName = SerializeJson<string>(name);
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://localhost:7976/PersonService.svc/rest/person/update");
                UTF8Encoding encoding = new UTF8Encoding();
                string postData = "{\"name\":" + "\"" + name + "\"}";
                Debug.WriteLine(postData);
                byte[] data = encoding.GetBytes(postData);

                webReq.Method = "POST";
                webReq.ContentType = "application/json; charset=utf-8";
                webReq.ContentLength = data.Length;


                using (Stream stream = webReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();
                if (response.GetResponseStream() != null)
                {

                
                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                PersonModel jsonObj = JsonConvert.DeserializeObject<PersonModel>(responseString);
                getPersonJSONBox.Text = jsonObj.Name + " - " + jsonObj.Age;
                    }
                //getPersonJSONBox.Text = responseString;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
            }

        }

        public static string SerializeJson<T>(T obj)
        {
            var settings = new JsonSerializerSettings() { DateFormatHandling = DateFormatHandling.MicrosoftDateFormat };
            return JsonConvert.SerializeObject(obj, settings);
        }

        private void test2()
        {
            string text = "";
            string url = string.Format("http://localhost:7976/PersonService.svc/rest/jsonpostobject/{0}", "Hans");
            string urlEasy = string.Format("http://localhost:7976/PersonService.svc/rest/json/{0}", 23);
            var request = WebRequest.Create(urlEasy);
            Debug.WriteLine(url);


            var response = (HttpWebResponse)request.GetResponse();
            if (response.GetResponseStream() != null)
            {
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    text = sr.ReadToEnd();
                }
            }

            getPersonJSONBox.Text = text;

            //PersonModel jsonObj = JsonConvert.DeserializeObject<PersonModel>(text);
            //getPersonJSONBox.Text = jsonObj.Name + " - " + jsonObj.Age;
            
        }
    }
}