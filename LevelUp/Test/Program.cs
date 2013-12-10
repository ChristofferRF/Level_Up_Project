using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using DataAccess;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            User demoUser = new User();
            UserController userCtr = new UserController();
            string username = "kielgasten";
            string password = "meh";
            

            demoUser = userCtr.GetUser(username, password);

            if (demoUser != null)
            {
                Console.WriteLine("succes \n");
                //if (user.Username == username && user.Password == password)
                //{
                //    Console.WriteLine("more succes");
                //}
                //else
                //{
                //    Console.WriteLine("incorrect username found");
                //}
                Console.WriteLine("UserID: " + demoUser.UserId.ToString() + "\n");
                Console.WriteLine("Username: " + demoUser.Username.ToString() + "\n");
                Console.WriteLine("Password: " + demoUser.Password.ToString() + "\n");
                Console.WriteLine("Age: " + demoUser.Age.ToString() + "\n");
                Console.WriteLine("Weight: " + demoUser.Weight.ToString() + "\n");
                //List<Achievement> list = userCtr.GetUsersAchievements(6);
                //Console.WriteLine("ach test: " + list[0].Name.ToString());
                Console.WriteLine("Achievement: " + demoUser.Achievements[0].Name.ToString());
                Console.WriteLine("Title: " + demoUser.Titles[0].Name.ToString());

                //Console.WriteLine("Achievements: " + "\n");
                //foreach (Achievement a in demoUser.Achievements)
                //{
                //    Console.WriteLine("Achievement: " + a.Name + "\n");
                //}
                //Console.WriteLine("user has no achievements");

                //Console.WriteLine("Titles: " + "\n");
                //foreach (Title t in demoUser.Titles)
                //{
                //    Console.WriteLine("Title: " + t.Name + "\n");
                //}

                //Console.WriteLine("user has no titles");

                //Console.WriteLine("user is null");
            }
        }
    }
}
