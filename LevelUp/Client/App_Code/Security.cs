using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Globalization;
using System.Security.Cryptography;
using DataAccess;

namespace Client.App_Code
{
    public static class Security
    {

        public static string HashMe(string password)
        {
            string hash = Convert.ToBase64String(System.Security.Cryptography.MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(password)));
            return hash;
        }

        //public static string CompareHash(string password)
        //{
        //    string hashed = HashMe(password);
        //    if (string.Compare(hashed, password) == 0)
        //    {
        //        equal = true;
        //    }

        //    return equal;
        //}
    }
}