using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;   //HttpWebRequest, WebRequest
using System.Diagnostics;
using System.IO;    //StreamWriter
using DataAccess;

namespace Client.App_Code
{
    public class AchievementCalls
    {
        public static Achievement GetAchievement(string userName, string password)
        {
            Achievement returnAchievement = new Achievement();

            string jsonString = "{\"UserName\":" + "\"" + userName + "\", " + "\"Password\":" + "\"" + password + "\"" + "}";
            Debug.WriteLine(jsonString);

            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://localhost:3369/LevelService.svc/achievements/get");
            webReq.Method = "POST";                                     //Set metodetypen. Default er POST, men vi skriver det ALTID alligevel.
            webReq.ContentType = "application/json; charset=utf-8";     //Sæt contenttypen, i.e Sæt til JSON
            webReq.ContentLength = jsonString.Length;                     //Længden på strengen
            Debug.WriteLine(webReq.ContentLength.ToString() + jsonString.Length.ToString());

            using (StreamWriter sw = new StreamWriter(webReq.GetRequestStream()))   //Opret en streamwriter med vores request som parameter (aner ikke hvad requeststream er, slå det selv op)
            {
                sw.Write(jsonString);
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();           //Opret et objekt der kan modtage svar på vores request
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))    //Opret et objekt der kan læse svaret
                {
                    string text = sr.ReadToEnd();                           //Læs svaret igennem og gem det i en streng. Det er JSON streng svaret kommer i.

                    returnAchievement = JSONhelper.JsonDeserialize<Achievement>(text);    //kør json-strengen igennem deserialiseringen, med PersonModel som type objekt
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return returnAchievement;
        }

        
    }
}