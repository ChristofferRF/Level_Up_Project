using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void CreateUserTest()
        {
            string name = "Bill gates";
            string username = "bg";
            string password = "hereiam";
            int age = 23;
            
            ControlLayer.AppUserCtr auctr = new ControlLayer.AppUserCtr();
            auctr.createUser(name, username, password, age);
        }
    }
}
