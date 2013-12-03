using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;

namespace UnitTest
{
    [TestClass]
    public class LogEntryTest
    {
        [TestMethod]
        public void LogEntryTest()
        {
            int result = -1;
            LogEntryController logCon = new LogEntryController();

            string typeOfExcercise = "Running";
            string distance = "22km";
            int minutes = 90;

            result = logCon.AddEntryToDb(typeOfExcercise, distance, minutes);

            if(result != -1)
            {   

                //asd
                Console.WriteLine("It incremented");
            }
           
        }
    }
}
