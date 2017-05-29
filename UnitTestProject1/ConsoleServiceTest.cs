using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using FizzBuzzGame;

namespace UnitTestProject1
{
    [TestClass]
    public class ConsoleServiceTest
    {
        ConsoleService CS;
        [TestInitialize]
        public void SetUp()
        {
            CS = new ConsoleService();
        }
        [TestMethod]
        public void GetIntInputShouldReturnPositiveNumberIfValidInput()
        {
            var sr = new StringReader("5");
            Console.SetIn(sr);
            var result = CS.GetIntInput();
            Assert.IsTrue(result == 5);
        }

        [TestMethod]
        public void GetStringInputShouldReturnStringIfValidInput()
        {
            var sr = new StringReader("Hello");
            Console.SetIn(sr);
            var result = CS.GetStringInput();
            Assert.IsTrue(result == "Hello");
        }

        [TestMethod]
        public void ValidatePositiveIntShouldReturnTrueIfPositiveInt()
        {
            Assert.IsTrue(CS.ValidatePositiveInt(1));
        }

        [TestMethod]
        public void ValidatePositiveIntShouldReturnFalseIfNotPositiveInt()
        {
            Assert.IsFalse(CS.ValidatePositiveInt(-1));
        }

        [TestMethod]
        public void ValidateIsAlphabetsShouldReturnTrueIfAlphabetsOnly()
        {
            Assert.IsTrue(CS.ValidateIsAlphabets("Werd"));
        }

        [TestMethod]
        public void ValidateIsAlphabetsShouldReturnFalseIfNotAlphabetsOnly()
        {
            Assert.IsFalse(CS.ValidateIsAlphabets("Werd1"));
        }

        [TestMethod]
        public void ValidateGameInputShouldReturnTrueIfValidInput()
        {
            Assert.IsTrue(CS.ValidateGameInput("R"));
            Assert.IsTrue(CS.ValidateGameInput("r"));
            Assert.IsTrue(CS.ValidateGameInput("1"));
        }

        [TestMethod]
        public void ValidateGameInputShouldReturnFalseIfInvalidInput()
        {
            Assert.IsFalse(CS.ValidateGameInput("potato"));
            Assert.IsFalse(CS.ValidateGameInput("-1"));
        }

    }
}
