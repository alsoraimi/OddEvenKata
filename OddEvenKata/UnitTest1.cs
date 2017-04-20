using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OddEvenKata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Expected ="odd";
            Assert.AreEqual(Expected, Odd_Even_Kata.GetOddEvenKata(1));

        }
        [TestMethod]
        public void TestMethod2()
        {
            string Expected = "even";
            Assert.AreEqual(Expected, Odd_Even_Kata.GetOddEvenKata(2));

        }

        [TestMethod]
        public void TestMethod3()
        {
            string Expected = "odd";
            Assert.AreEqual(Expected, Odd_Even_Kata.GetOddEvenKata(3));

        }

        [TestMethod]
        public void TestMethod4()
        {
            string Expected = "even";
            Assert.AreEqual(Expected, Odd_Even_Kata.GetOddEvenKata(4));

        }
        [TestMethod]
        public void TestMethod53()
        {
            string Expected = "prime";
            Assert.AreEqual(Expected, Odd_Even_Kata.GetOddEvenKata(53));

        }

        [TestMethod]
        public void TestMethod51()
        {
            string Expected = "odd";
            Assert.AreEqual(Expected, Odd_Even_Kata.GetOddEvenKata(51));

        }



    }
}
