using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using Controller;
using System.Diagnostics;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void TestCreateUser()
        {
            /* create a user | check that he can be found in db | compare */
            string UserNameExpected = "MrArnold";
            string PassWordExpected = "Wuaa";
            string NameExpected = "Schwarz";
            int AgeExpected = 22;
            double WeightExpected = 92;
            double HeightExpected = 185;
            long XpExpected = 1292; 
            int LevelExpected = 2;
            string privacyName = "none";
            string privacyAge = "none";
            string privacyHeight = "none";
            string privacyWeight = "none";

            // Add the expected user to DB
            UserController userCtr = new UserController();
            userCtr.AddUserToDb(UserNameExpected,PassWordExpected,NameExpected,AgeExpected,WeightExpected,HeightExpected,XpExpected,LevelExpected,privacyName, privacyAge, privacyHeight, privacyWeight);

            /* GET THE ACTUAL USER FROM USERNAME AND PASSWORD */
            User actualUser = new User();
            actualUser = userCtr.GetUser(UserNameExpected,PassWordExpected);
            
            // Properties of the Actual user - retrieved from DB
            string userNameActual = actualUser.UserName;
            string passWordActual = actualUser.Password;
            string nameActual = actualUser.Name;
            int ageActual = actualUser.Age;
            double weightActual = actualUser.Weight;
            double heightActual = actualUser.Height;
            long xpActual = actualUser.Xp;
            int levelActual = actualUser.Level;

            /* COMPARE */
            Assert.AreEqual(UserNameExpected,userNameActual);
            Assert.AreEqual(PassWordExpected,passWordActual);
            Assert.AreEqual(NameExpected,nameActual);
            Assert.AreEqual(AgeExpected,ageActual);
            Assert.AreEqual(WeightExpected,weightActual);
            Assert.AreEqual(HeightExpected,heightActual);
            Assert.AreEqual(XpExpected,xpActual);
            Assert.AreEqual(LevelExpected,levelActual);
            // DONE
        }

        [TestMethod]
        public void TestGetUser()
        {
            /* define user stats | find user on those stats | see if test can get the equivalent data in db */
            /* EXPECTED */
            int UserIdExpected = 1;
            string UserNameExpected = "derp";
            string PassWordExpected = "1234";
            string NameExpected = "niels";
            int AgeExpected = 17;
            int WeightExpected = 80;
            int HeightExpected = 175;
            long LevelExpected = 2;
            int XpExpected = 4178;
             

            /* GET THE USER */
            UserController userctr = new UserController();
            User expectedUser = new User();
            expectedUser = userctr.GetUser(UserNameExpected, PassWordExpected);


            /* COMPARE */
            int useridActual = expectedUser.UserId;
            string usernameActual = expectedUser.Username;
            string passwordActual = expectedUser.Password;
            string nameActual = expectedUser.Name;
            int ageActual = expectedUser.Age;
            double weightActual = expectedUser.Weight;
            double heightActual = expectedUser.Height;
            long xpActual = expectedUser.Xp;
            int levelActual = expectedUser.Level;

            Assert.AreEqual(UserIdExpected,useridActual);
            Assert.AreEqual(UserNameExpected, usernameActual);
            Assert.AreEqual(PassWordExpected, passwordActual);
            Assert.AreEqual(NameExpected,nameActual);
            Assert.AreEqual(AgeExpected,ageActual);
            Assert.AreEqual(WeightExpected,weightActual);
            Assert.AreEqual(HeightExpected,heightActual);
            Assert.AreEqual(XpExpected,xpActual);
            Assert.AreEqual(LevelExpected, levelActual);
            // DONE //
        }

        [TestMethod]
        public void TestUpdateUser()
        {
            UserController userCtr = new UserController();
            string userName = "kielgasten";
            string passWord = "meh";
            long xp = 1;
            User userToUpdate = new User();
            User userafterupdate = new User();


            /* EXPECTED */
            // The user to update
            userToUpdate = userCtr.GetUser(userName, passWord);
            // Expected xp
            long xpbeforeupdate = userToUpdate.Xp;


            /* THE UPDATE */
            // Update the user with username with amount of xp
            userCtr.UpdateUserXP(userName, xp);
            

            /* ACTUAL */
            // Get the user after the update - Retrieved from DB
            userafterupdate = userCtr.GetUser(userName, passWord);
            // Actual xp
            long xpafterupdate = (userafterupdate.Xp)-1; // remember to increment manually before running test


            /* COMPARE */
            Assert.AreEqual(xpbeforeupdate, xpafterupdate); // we always test for an increment of one only
        }

        [TestMethod]
        public void TestUpdateUserProfile()
        {
            string userName = "MrArnold";
            string passWord = "Wuaa";
            string name = "Schwarz";
            int age = 22;
            double weight = 92;
            double height = 185;
            int level = 3;
            long xp = 2000;

            UserController userCtr = new UserController();
            userCtr.UpdateUserProfile(userName,passWord,name,age,weight,height,xp,level);
        }

        [TestMethod]
        public void TestAssignAchievement()
        {
            List<Achievement> aList = new List<Achievement>();
            Achievement a1 = new Achievement
            {
                AchievementId = 1
            };

            Achievement a2 = new Achievement
            {
                AchievementId = 2
            };
            aList.Add(a1);
            aList.Add(a2);


            User u = new User
            {
                UserId = 56
            };

            UserController userCtr = new UserController();
            userCtr.AssignAchievement(aList, u);
        }
    }
}