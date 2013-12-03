using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel.Web;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Text;  //Til Encoding
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using RESTtest;
namespace RESTClient
{
    public partial class client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Serialiser et object til en JSON streng.
        /// Jeg bruger det ikke her i eksemplet, men det er til at sende til servicen
        /// Jeg har ikke skrevet de her par metoder, derfor ingen detailkommentarer.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <returns></returns>
        private string JSONSerializer<T>(T type)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            ser.WriteObject(ms, type);
            string jsonString = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();
            return jsonString;
        }

        /// <summary>
        /// Deserialiser en JSON-streng til et givent objekt.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static T JsonDeserialize<T>(string jsonString)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            T obj = (T)ser.ReadObject(ms);
            return obj;
        }

        private void test()
        {

            try
            {
                string name = "joe";    //Ændringen
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://localhost:7976/PersonService.svc/rest/person/update"); //Addressen på metoden
                string postData = "{\"name\":" + "\"" + name + "\"}";       //Manuel serialisering..

                webReq.Method = "POST";                                     //Set metodetypen. Default er POST, men vi skriver det ALTID alligevel.
                webReq.ContentType = "application/json; charset=utf-8";     //Sæt contenttypen, i.e Sæt til JSON
                webReq.ContentLength = postData.Length;                     //Længden på strengen
                Debug.WriteLine(webReq.ContentLength.ToString());

                using (StreamWriter sw = new StreamWriter(webReq.GetRequestStream()))   //Opret en streamwriter med vores request som parameter (aner ikke hvad requeststream er, slå det selv op)
                {
                    sw.Write(postData); //Skyder requesten afsted.
                }

                HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();           //Opret et objekt der kan modtage svar på vores request
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))    //Opret et objekt der kan læse svaret
                {
                    string text = sr.ReadToEnd();                           //Læs svaret igennem og gem det i en streng. Det er JSON streng svaret kommer i.

                    PersonModel pm = JsonDeserialize<PersonModel>(text);    //kør json-strengen igennem deserialiseringen, med PersonModel som type objekt
                    getPersonJSONBox.Text = "navn: " + pm.Name + " alder: " + pm.Age; //tadaa...
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

        }

        /// <summary>
        /// Klik event til test metoden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void theButton_Click(object sender, EventArgs e)
        {
            test();
        }
    }
}