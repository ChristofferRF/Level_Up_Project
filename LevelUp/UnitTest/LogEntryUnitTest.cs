using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;
using DataAccess;
using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class LogEntryUnitTest
    {
        [TestMethod]
        public void TestCreateLogEntry()
        {
            // Expected object properties
            string typeOfExcerciseExpected = "Running";
            string distanceExpected = "22km";
            int hoursExpected = 1;
            int minutesExpected = 34;
            int secondsExpected = 54;
            int userIdExpected = 6;
            int logEntryIdExpected = 43;
            DateTime DateExpected = new DateTime(2013,12,12);
            //string dateExpected = "2013-12-11"; // Datetime Issues
            //Debug.WriteLine("Expected : " + dateExpected);


            /* create a Log | check that Log can be found in db | compare */
            // Add the Expected LogEntry to DB
            LogEntryController leCtr = new LogEntryController();
            leCtr.AddEntryToDb(typeOfExcerciseExpected, distanceExpected, hoursExpected, minutesExpected, secondsExpected, DateExpected);

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
            //int logEntryIdActual = actualEntry.LogEntryId;
            //string dateActual = actualEntry.DateCreated.ToShortDateString();
            //Debug.WriteLine("Actual   : " + dateActual);


            /* COMPARE */
            Assert.AreEqual(typeOfExcerciseExpected,typeOfExcerciseActual);
            Assert.AreEqual(distanceExpected,distanceActual);
            Assert.AreEqual(hoursExpected,hoursActual);
            Assert.AreEqual(minutesExpected,minutesActual);
            Assert.AreEqual(secondsExpected,secondsActual);
            Assert.AreEqual(userIdExpected,userIdActual);
            //Assert.AreEqual(logEntryIdExpected,logEntryIdActual);
            //Assert.AreEqual(dateExpected,dateActual, dateActual.ToString());
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
            DateTime dateExpected = new DateTime(2013, 12, 11);

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
            DateTime dateActual = actualLogEntry.DateCreated;

            Assert.AreEqual(typeOfExcerciseExpected,typeOfExerciseActual);
            Assert.AreEqual(distanceExpected,distanceActual);
            Assert.AreEqual(hoursExpected,hoursActual);
            Assert.AreEqual(minutesExpected,minutesActual);
            Assert.AreEqual(secondsExpected,secondsActual);
            Assert.AreEqual(logEntryIdExpected,logEntryIdActual);
            Assert.AreEqual(userIdExpected,userIdActual);
            Assert.AreEqual(dateExpected,dateActual);
            // DONE
        }

        [TestMethod]
        public void TestGetLastFiveLogs()
        {
            //Coll
        }
    }
}