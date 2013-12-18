using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using Controller;

namespace UnitTest
{
    /// <summary>
    /// Summary description for AchievementUnitTest
    /// </summary>
    [TestClass]
    public class AchievementUnitTest
    {


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestGetLatestAchievement()
        {
            /* Definition of variables Ø*/
            int AchIdExpected = 1;
            string AchNameExpected = "Collector";
            string AchDescriptionExpected = "this is an achievement";
            int AchValueExpected = 10;
            string AchDateExpected = "13-03-2011 00:00:00";
             //int AchXpToAchieveExpected = -1;
             //int AchLvlToAchieveExpected = -1;

            /* Get the achievement */
            AchievementController achCtr = new AchievementController();
            Achievement expectedAch = new Achievement();
            expectedAch = achCtr.GetLatestAchievement(AchIdExpected);

            /* Comparison */
            int AchIdActual = expectedAch.AchievementId;
            string AchNameActual = expectedAch.Name;
            string AchDescriptionActual = expectedAch.Description;
            int AchValueActual = expectedAch.Value;
            string AchDateActual = expectedAch.DateAchieved.ToString();
                //int AchXpToAchieveActual = expectedAch.x


            Assert.AreEqual(AchIdExpected, AchIdActual);
            Assert.AreEqual(AchNameExpected, AchNameActual);
            Assert.AreEqual(AchDescriptionExpected, AchDescriptionActual);
            Assert.AreEqual(AchValueExpected, AchValueActual);
            Assert.AreEqual(AchDateExpected, AchDateActual);
        }
    }
}
