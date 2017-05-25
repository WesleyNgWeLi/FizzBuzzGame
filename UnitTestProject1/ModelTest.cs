using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzGame;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for ModelTest
    /// </summary>
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FizzBuzzRulesClassModel m = new FizzBuzzRulesClassModel(8, "potato");

            Assert.AreEqual(m.ModuloNumber, 8);
            Assert.AreEqual(m.ReplacementWord, "potato");
        }
    }
}
