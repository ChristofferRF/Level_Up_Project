using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel.Web;
using RESTClient.Service;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace RESTClient
{
    public partial class client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            test();
        }



        private void test()
        {
            string text = "";
            string url = string.Format("http://localhost:7976/PersonService.svc/rest/jsonpostobject/{0}", "Hans");
            string urlEasy = string.Format("http://localhost:7976/PersonService.svc/rest/json/{0}", 23);
            var request = WebRequest.Create(url);
            Debug.WriteLine(url);


            var response = (HttpWebResponse)request.GetResponse();
            if (response.GetResponseStream() != null)
            {
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    text = sr.ReadToEnd();
                }
            }

            //getPersonJSONBox.Text = text;

            PersonModel jsonObj = JsonConvert.DeserializeObject<PersonModel>(text);
            getPersonJSONBox.Text = jsonObj.Name + " - " + jsonObj.Age;
            
        }
    }
}