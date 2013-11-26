using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting; // using reference
using UnitTestSpikeFormsApp; // using reference

namespace UnitTest
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void addtest()
        {
            int a = 2;
            int b = 3;

            int expected = 5;
            var calc = new Calculator();
            int actualResult = calc.add(a,b);
            Assert.AreEqual(expected,actualResult);
        }
    }
}