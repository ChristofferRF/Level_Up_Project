﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.Entity;

namespace Controller
{
    public class UserController
    {
        public UserController()
        {

        }

        public User AddUserToDb(string username, string password, string name, int age, int weight, int height)
        {
            User demoUser = new User();
            int result = -1;

            using (var db = new DataAccessContext())
            {
                User user = new User
                {
                    Username = username,
                    Password = password,
                    Name = name,
                    Age = age,
                    Weight = weight,
                    Height = height,
                };

                db.Users.Add(user);
                result = db.SaveChanges();
            }

            if (result != -1)
                return demoUser;
            else
                return demoUser;
        }

    }
}
