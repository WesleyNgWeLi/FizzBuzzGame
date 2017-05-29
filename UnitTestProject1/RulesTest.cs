using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class RulesTest
    {

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ExpectFizzIfInputIsDivisibleBy3()
        {
        }
        [TestMethod]
        public void ExpectBuzzIfInputIsDivisibleBy5()
        {
        }
        [TestMethod]
        public void ExpectPopIfInputIsDivisibleBy3()
        {
        }
        [TestMethod]
        public void ExpectFizzBuzzIfInputIsDivisibleBy3And5()
        {
        }
        [TestMethod]
        public void ExpectFizzPopIfInputIsDivisibleBy3And7()
        {
        }
        [TestMethod]
        public void ExpectBuzzPopIfInputIsDivisibleBy5And7()
        {
        }
        [TestMethod]
        public void ExpectFizzBuzzPopIfInputIsDivisibleBy3And5And7()
        {
        }
        [TestMethod]
        public void ExpectNumberIfInputIsNotDivisibleByAnyRule()
        {
        }
        [TestMethod]
        public void ExpectCustomWordIfInputIsDivisibleByCustomRule()
        {
        }


    }
}
