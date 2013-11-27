using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class ApplicationUser
    {
        private string name;
        private string userName;
        private string passWord;
        private int age;

        public void createUser(string name, string username, string password, int age)
        {
            this.name = name;
            this.userName = username;
            this.passWord = password;
            this.age = age;
        }
    } 
}
