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
        FizzBuzzModelService MS;
        [TestInitialize]
        public void SetUp()
        {
            MS = new FizzBuzzModelService();
        }


        [TestMethod]
        public void WhenDeclaringNewRuleExpectSuccess()
        {
            FizzBuzzRulesClassModel m = new FizzBuzzRulesClassModel(8, "potato");
            Assert.AreEqual(m.ModuloNumber, 8);
            Assert.AreEqual(m.ReplacementWord, "potato");
        }

        [TestMethod]
        public void ExpectSortedListWhenCallingSortModel()
        {
            List<FizzBuzzRulesClassModel> m = new List<FizzBuzzRulesClassModel>();
            m.Add(new FizzBuzzRulesClassModel(22, "b"));
            m.Add(new FizzBuzzRulesClassModel(1, "a"));
            m.Add(new FizzBuzzRulesClassModel(12, "ab"));

            MS.SortModel(ref m);

            Assert.IsTrue(m[0].ModuloNumber == 1);
            Assert.IsTrue(m[0].ReplacementWord == "a");
            Assert.IsTrue(m[1].ModuloNumber == 12);
            Assert.IsTrue(m[1].ReplacementWord == "ab");
            Assert.IsTrue(m[2].ModuloNumber == 22);
            Assert.IsTrue(m[2].ReplacementWord == "b");
        }
    }
}
