using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;
using DataAccess;

namespace UnitTest
{
    [TestClass]
    public class LogEntryUnitTest
    {
        [TestMethod]
        public void TestCreateLogEntry()
        {
            /*
            LogEntry demoLog = new LogEntry();
            LogEntryController logCon = new LogEntryController();

            string typeOfExcercise = "Running";
            string distance = "22km";
            int hours = 1;
            int minutes = 30;
            int seconds = 0;

            demoLog = logCon.AddEntryToDb(typeOfExcercise, distance, hours, minutes, seconds);

            if (demoLog.TypeOfExcercise == typeOfExcercise && demoLog.Distance == distance && demoLog.Hours == hours && demoLog.Minutes == minutes && demoLog.Seconds == seconds)
            {
                Console.WriteLine("Great justice!");
            }
            */

            // Expected object properties
            string typeOfExcerciseExpected = "Running";
            string distanceExpected = "22km";
            int hoursExpected = 1;
            int minutesExpected = 34;
            int secondsExpected = 54;
            int userIdExpected = 6;
            int logEntryIdExpected = 22;

            /* create a user | check that he can be found in db | compare */

            // Add the Expected LogEntry to DB
            LogEntryController leCtr = new LogEntryController();
            leCtr.AddEntryToDb(typeOfExcerciseExpected, distanceExpected,hoursExpected,minutesExpected,secondsExpected);


            // Get the actual LogEntry from Entry Id
            LogEntry actualEntry = new LogEntry();
            actualEntry = leCtr.GetEntryFromDB(logEntryIdExpected,userIdExpected); //int entryId, int userId
            

            // Properties of the Actual LogEntry
            string typeOfExcerciseActual = actualEntry.TypeOfExcercise;
            string distanceActual = actualEntry.Distance;
            int hoursActual = actualEntry.Hours;
            int minutesActual = actualEntry.Minutes;
            int secondsActual = actualEntry.Seconds;
            int userIdActual = actualEntry.UserId;
            int logEntryIdActual = actualEntry.LogEntryId;


            /* COMPARE */
            Assert.AreEqual(typeOfExcerciseExpected,typeOfExcerciseActual);
            Assert.AreEqual(distanceExpected,distanceActual);
            Assert.AreEqual(hoursExpected,hoursActual);
            Assert.AreEqual(minutesExpected,minutesActual);
            Assert.AreEqual(secondsExpected,secondsActual);
            Assert.AreEqual(userIdExpected,userIdActual);
            Assert.AreEqual(logEntryIdExpected,logEntryIdActual);
        }

        [TestMethod]
        public void TestGetLogEntry()
        {
            /* EXPECTED */
            string typeOfExcerciseExpected = "Running";
            string distanceExpected = "22km";
            int hoursExpected = 1;
            int minutesExpected = 34;
            int secondsExpected = 54;
            int userIdExpected = 6;
            int logEntryIdExpected = 22;


            /* GET THE USER */
            LogEntryController leCtr = new LogEntryController();
            LogEntry actualLogEntry = new LogEntry();
            actualLogEntry = leCtr.GetEntryFromDB(logEntryIdExpected,userIdExpected);


            /* COMPARE */
            string typeOfExerciseActual = actualLogEntry.TypeOfExcercise;
            string distanceActual = actualLogEntry.Distance;
            int hoursActual = actualLogEntry.Hours;
            int minutesActual = actualLogEntry.Minutes;
            int secondsActual = actualLogEntry.Seconds;
            int userIdActual = actualLogEntry.UserId;
            int logEntryIdActual = actualLogEntry.LogEntryId;

            Assert.AreEqual(typeOfExcerciseExpected,typeOfExerciseActual);
            Assert.AreEqual(distanceExpected,distanceActual);
            Assert.AreEqual(hoursExpected,hoursActual);
            Assert.AreEqual(minutesExpected,minutesActual);
            Assert.AreEqual(secondsExpected,secondsActual);
            Assert.AreEqual(logEntryIdExpected,logEntryIdActual);
            Assert.AreEqual(userIdExpected,userIdActual);
            // DONE
        }
    }
}