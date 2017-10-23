using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication6;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 1;
            string actual = Program.CowCounter(n);
            string expected = "1 Корова";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            int n = 11;
            string actual = Program.CowCounter(n);
            string expected = "11 Коров";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod111()
        {
            int n = 111;
            string actual = Program.CowCounter(n);
            string expected = "111 Коров";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod121()
        {
            int n = 121;
            string actual = Program.CowCounter(n);
            string expected = "121 Корова";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod125()
        {
            int n = 125;
            string actual = Program.CowCounter(n);
            string expected = "125 Коров";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod489()
        {
            int n = 489;
            string actual = Program.CowCounter(n);
            string expected = "489 Коров";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod101()
        {
            int n = 101;
            string actual = Program.CowCounter(n);
            string expected = "101 Корова";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1001()
        {
            int n = 1001;
            string actual = Program.CowCounter(n);
            string expected = "1001 Корова";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int n = 2;
            string actual = Program.CowCounter(n);
            string expected = "2 Коровы";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            int n = 8;
            string actual = Program.CowCounter(n);
            string expected = "8 Коров";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod0()
        {
            int n = 0;
            string actual = Program.CowCounter(n);
            string expected = "0 Коров";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int n = 4;
            string actual = Program.CowCounter(n);
            string expected = "4 Коровы";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            int n = 10;
            string actual = Program.CowCounter(n);
            string expected = "10 Коров";
            Assert.AreEqual(expected, actual);
        }


    }
}
