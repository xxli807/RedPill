using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RedPillUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            RedPill.RedPill redPill = new RedPill.RedPill();
            var s = redPill.FibonacciNumber(-4);
            s = redPill.FibonacciNumber(9);
        }
    }
}
