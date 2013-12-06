using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using Controller;

namespace UnitTest
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void TestCreateUser()
        {
            User demoUser = new User();
            UserController userCtr = new UserController();

            string username = "derp";
            string password = "1234";
            string name = "Thorstein";
            int age = 17;
            double weight = 80;
            double height = 175;

            demoUser = userCtr.AddUserToDb(username, password, name, age, weight, height);

            if (demoUser.Username == username && demoUser.Password == password && demoUser.Name == name && demoUser.Age == age
                && demoUser.Weight == weight && demoUser.Height == height)
            {
                Console.WriteLine("The user object is for real!");
            }
        }

        [TestMethod]
        public void TestGetUser()
        {
            UserController userCtr = new UserController();
            string username = "kielgasten";
            string password = "meh";
            string name = "Ronnie";
            int age = 31;
            double weight = 85;
            double height = 170;
            int level = 0;
            long xp = 0;
            string achievementName = "Collector";
            string Title = "Supreme Grand Master";

            User demoUser = new User();

            demoUser = userCtr.GetUser(username, password);

            if (demoUser.Username == username && demoUser.Password == password)
            {
                Console.WriteLine("succes");
                Console.WriteLine("username" + demoUser.Username.ToString() + "\n");
                Console.WriteLine("Achievement" + demoUser.Achievements[0].Name + "\n");
                Console.WriteLine("Title" + demoUser.Titles[0].Name);
            }

            
                
        
        
        }
    }
}

