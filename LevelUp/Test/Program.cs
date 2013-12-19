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
            TestGetUserLastFiveLogs();
            //TestGetUser();
        }
        public static void TestGetUser()
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
                Console.WriteLine("Username: " + demoUser.UserName.ToString() + "\n");
                Console.WriteLine("Password: " + demoUser.Password.ToString() + "\n");
                Console.WriteLine("Age: " + demoUser.Age.ToString() + "\n");
                Console.WriteLine("Weight: " + demoUser.Weight.ToString() + "\n");
                //List<Achievement> list = userCtr.GetUsersAchievements(6);
                //Console.WriteLine("ach test: " + list[0].Name.ToString());
                Console.WriteLine("Achievement: " + demoUser.Achievements[0].Name.ToString());
                Console.WriteLine("Title: " + demoUser.Titles[0].Name.ToString());
                Console.ReadLine();

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

        public static void TestGetUserLastFiveLogs()
        {
            UserController userCtr = new UserController();
            List<LogEntry> listTest = new List<LogEntry>();

            listTest = userCtr.GetFiveLatestLogs(6);

            if (listTest != null)
            {
                foreach (LogEntry log in listTest)
                {
                    Console.WriteLine("LogEntryId: " + log.LogEntryId + "\n");
                    Console.WriteLine("Type of Excercise: " + log.TypeOfExcercise + "\n");
                    Console.WriteLine("Distance: " + log.Distance + "\n");
                    Console.WriteLine("Hours: " + log.Hours + "\n");
                    Console.WriteLine("Minutes: " + log.Minutes + "\n");
                    Console.WriteLine("Seconds: " + log.Seconds + "\n");
                    //Console.WriteLine("Date created: " + log.DateCreated + "\n");
                    //Console.WriteLine("Cal: " + log.Kcal + "\n");
                }
            }
            else
            {
                Console.WriteLine("the list is null");
            }
            Console.ReadLine();
        }
    }
}
