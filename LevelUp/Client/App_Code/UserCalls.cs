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
    public static class UserCalls
    {
        public static User AddUser(User u)
        {
            User returnUser = new User();

            string jsonString = JSONhelper.JSONSerializer<User>(u);
            Debug.WriteLine(jsonString);
            
            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://localhost:3369/LevelService.svc/users/add");
            webReq.Method = "POST";                                     //Set metodetypen. Default er POST, men vi skriver det ALTID alligevel.
            webReq.ContentType = "application/json; charset=utf-8";     //Sæt contenttypen, i.e Sæt til JSON
            webReq.ContentLength = jsonString.Length;                     //Længden på strengen
            Debug.WriteLine(webReq.ContentLength.ToString() + jsonString.Length.ToString());

            using (StreamWriter sw = new StreamWriter(webReq.GetRequestStream()))   //Opret en streamwriter med vores request som parameter (aner ikke hvad requeststream er, slå det selv op)
            {
                sw.Write(jsonString); //Skyder requesten afsted.
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();           //Opret et objekt der kan modtage svar på vores request
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))    //Opret et objekt der kan læse svaret
                {
                    string text = sr.ReadToEnd();                           //Læs svaret igennem og gem det i en streng. Det er JSON streng svaret kommer i.

                    returnUser = JSONhelper.JsonDeserialize<User>(text);    //kør json-strengen igennem deserialiseringen, med PersonModel som type objekt
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return returnUser;
        }


        public static User GetUser(string userName, string password)
        {
            User returnUser = new User();

            string jsonString = "{\"UserName\":" + "\"" + userName + "\", " + "\"Password\":" + "\"" + password +  "\"" + "}";
            Debug.WriteLine(jsonString);
            
            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://localhost:3369/LevelService.svc/users/get");
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

                    returnUser = JSONhelper.JsonDeserialize<User>(text);    //kør json-strengen igennem deserialiseringen, med PersonModel som type objekt
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return returnUser;
        }

        public static User UpdateUser(User u)
        {
            User returnUser = new User();

            string jsonString = JSONhelper.JSONSerializer<User>(u);
            Debug.WriteLine(jsonString);

            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://localhost:3369/LevelService.svc/users/update");
            webReq.Method = "POST";                                     //Set metodetypen. Default er POST, men vi skriver det ALTID alligevel.
            webReq.ContentType = "application/json; charset=utf-8";     //Sæt contenttypen, i.e Sæt til JSON
            webReq.ContentLength = jsonString.Length;                     //Længden på strengen
            Debug.WriteLine(webReq.ContentLength.ToString() + jsonString.Length.ToString());

            using (StreamWriter sw = new StreamWriter(webReq.GetRequestStream()))   //Opret en streamwriter med vores request som parameter (aner ikke hvad requeststream er, slå det selv op)
            {
                sw.Write(jsonString); //Skyder requesten afsted.
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();           //Opret et objekt der kan modtage svar på vores request
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))    //Opret et objekt der kan læse svaret
                {
                    string text = sr.ReadToEnd();                           //Læs svaret igennem og gem det i en streng. Det er JSON streng svaret kommer i.

                    returnUser = JSONhelper.JsonDeserialize<User>(text);    //kør json-strengen igennem deserialiseringen, med PersonModel som type objekt
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return returnUser;
        }

        public static List<LogEntry> GetFiveLatestLogs(int userId)
        {
            List<LogEntry> latestLogs = new List<LogEntry>();

            string jsonString = "{\"UserId\":" + "\"" + userId.ToString() + "\"" + "}";
            Debug.WriteLine(jsonString);

            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://localhost:3369/LevelService.svc/users/get/logs");


        public static void UpdateUserXP(string userName, long earnedXp)
        {
            User returnUser = new User();

            string jsonString = "{\"UserName\":" + "\"" + userName + "\", " + "\"EarnedXp\":" + "\"" + earnedXp.ToString() + "\"" + "}";
            Debug.WriteLine(jsonString);

            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://localhost:3369/LevelService.svc/users/update/xp");
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

                    latestLogs = JSONhelper.JsonDeserialize<List<LogEntry>>(text);    //kør json-strengen igennem deserialiseringen, med PersonModel som type objekt
                }
                HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();          //Skyder requesten afsted.

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return latestLogs;
        }
        }
            
    }
}