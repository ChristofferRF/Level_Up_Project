using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json; //DataContractSerializer
using System.Text;  //Encoding
using System.IO;    //Memorystream
using System.Web;

namespace Client.App_Code
{
    public static class JSONhelper
    {
        /// <summary>
        /// Serialiser et object til en JSON streng.
        /// Jeg bruger det ikke her i eksemplet, men det er til at sende til servicen
        /// Jeg har ikke skrevet de her par metoder, derfor ingen detailkommentarer.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string JSONSerializer<T>(T type)
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
    }
}