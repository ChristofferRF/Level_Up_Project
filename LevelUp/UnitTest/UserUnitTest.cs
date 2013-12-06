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
    }
}
