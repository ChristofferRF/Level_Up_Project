﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;
using System.Net;   //HttpWebRequest, WebRequest
using System.Diagnostics;
using System.IO;    //StreamWriter

namespace Client.App_Code
{
    public static class EntryCalls
    {
        public static LogEntry AddLogEntry(LogEntry entry)
        {
            LogEntry returnLog = new LogEntry();

            string jsonString = JSONhelper.JSONSerializer<LogEntry>(entry);
            Debug.WriteLine(jsonString);
            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://localhost:3369/LevelService.svc/entry/add"); //Addressen på metoden

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

                    returnLog = JSONhelper.JsonDeserialize<LogEntry>(text);    //kør json-strengen igennem deserialiseringen, med PersonModel som type objekt
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

           return returnLog;

        }

    }
               
}