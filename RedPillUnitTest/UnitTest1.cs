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
            var fibonacciNumber = redPill.FibonacciNumber(-4);
            fibonacciNumber = redPill.FibonacciNumber(9);
            fibonacciNumber = redPill.FibonacciNumber(93);


            var reverseWord = redPill.ReverseWords("12*O");
            reverseWord = redPill.ReverseWords("!!@12*O");


            var shape = redPill.WhatShapeIsThis(1, 2, 3);
            shape = redPill.WhatShapeIsThis(1, -2, 3);

        }
    }
}
