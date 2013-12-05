﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;
using DataAccess;

namespace UnitTest
{
    [TestClass]
    public class LogEntryUnitTest
    {
        [TestMethod]
        public void LogEntryTest()
        {
            LogEntry demoLog = new LogEntry();
            LogEntryController logCon = new LogEntryController();

            string typeOfExcercise = "Running";
            string distance = "22km";
            int hours = 1;
            int minutes = 90;
            int seconds = 0;

            demoLog = logCon.AddEntryToDb(typeOfExcercise, distance, hours, minutes, seconds);

            if(demoLog.TypeOfExcercise == typeOfExcercise && demoLog.Distance == distance && demoLog.Minutes == minutes)
            {   
                Console.WriteLine("Great justice!");
            }
           
        }
    }
}
