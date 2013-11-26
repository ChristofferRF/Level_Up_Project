using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace ControlLayer
{
    public class AppUserCtr
    {
        ModelLayer.ApplicationUser appUser = new ModelLayer.ApplicationUser();

        public void createUser(string name, string username, string password, int age)
        {
            appUser.createUser(name, username, password, age);
        }
    }
}