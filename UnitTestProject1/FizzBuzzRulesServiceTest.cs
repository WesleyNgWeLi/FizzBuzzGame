using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzGame;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class FizzBuzzRulesServiceTest
    {
        FizzBuzzModelService MS;
        List<FizzBuzzRulesClassModel> rules;
        FizzBuzzRulesService RS;
        [TestInitialize]
        public void SetUp()
        {
            MS = new FizzBuzzModelService();
            RS = new FizzBuzzRulesService();
            rules = new List<FizzBuzzRulesClassModel>();
            RS.DefaultRulesSetUp(ref rules);
        }
        [TestMethod]
        public void ExpectFizzBuzzPopRulesSetUpWhenCallingDefaultRulesSetUp()
        {
            List<FizzBuzzRulesClassModel> m = new List<FizzBuzzRulesClassModel>();
            RS.DefaultRulesSetUp(ref m);
            Assert.IsTrue(m.Count == 3);
            Assert.IsTrue(m[0].ModuloNumber == 3);
            Assert.IsTrue(m[0].ReplacementWord == "Fizz");
            Assert.IsTrue(m[1].ModuloNumber == 5);
            Assert.IsTrue(m[1].ReplacementWord == "Buzz");
            Assert.IsTrue(m[2].ModuloNumber == 7);
            Assert.IsTrue(m[2].ReplacementWord == "Pop");
        }

        [TestMethod]
        public void ExpectFizzIfInputIsDivisibleBy3()
        {
            string output = RS.DoRules(3, rules);
            Assert.IsTrue(output == "Fizz");
        }
        [TestMethod]
        public void ExpectBuzzIfInputIsDivisibleBy5()
        {
            string output = RS.DoRules(5, rules);
            Assert.IsTrue(output == "Buzz");
        }
        [TestMethod]
        public void ExpectPopIfInputIsDivisibleBy3()
        {
            string output = RS.DoRules(7, rules);
            Assert.IsTrue(output == "Pop");
        }
        [TestMethod]
        public void ExpectFizzBuzzIfInputIsDivisibleBy3And5()
        {
            string output = RS.DoRules(15, rules);
            Assert.IsTrue(output == "FizzBuzz");
        }
        [TestMethod]
        public void ExpectFizzPopIfInputIsDivisibleBy3And7()
        {
            string output = RS.DoRules(21, rules);
            Assert.IsTrue(output == "FizzPop");
        }
        [TestMethod]
        public void ExpectBuzzPopIfInputIsDivisibleBy5And7()
        {
            string output = RS.DoRules(35, rules);
            Assert.IsTrue(output == "BuzzPop");
        }
        [TestMethod]
        public void ExpectFizzBuzzPopIfInputIsDivisibleBy3And5And7()
        {
            string output = RS.DoRules(105, rules);
            Assert.IsTrue(output == "FizzBuzzPop");
        }
        [TestMethod]
        public void ExpectNumberIfInputIsNotDivisibleByAnyRule()
        {
            string output = RS.DoRules(2, rules);
            Assert.IsTrue(output == "2");
        }
        [TestMethod]
        public void ExpectNewRuleWhenCallingAddRule()
        {
            List<FizzBuzzRulesClassModel> m = new List<FizzBuzzRulesClassModel>();
            RS.AddRule(1, "w", ref m);
            Assert.IsTrue(m.Count == 1);
        }
        [TestMethod]
        public void ExpectCustomWordIfInputIsDivisibleByCustomRule()
        {
            RS.AddRule(17, "Prime", ref rules);
            string output = RS.DoRules(17, rules);
            Assert.IsTrue(output == "Prime");
        }


    }
}
