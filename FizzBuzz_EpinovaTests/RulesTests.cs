using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz_Epinova;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_Epinova.Tests
{
    [TestClass()]
    public class RulesTests
    {
        private Rules rules = new Rules();

        [TestMethod()]
        public void FizzBuzzTest()
        {
            rules.AddRule(3, "Fizz");
            rules.AddRule(5, "Buzz");

            Assert.AreEqual(rules.GetNumberAsSingleKeyword(3), "Fizz");
            Assert.AreEqual(rules.GetNumberAsSingleKeyword(5), "Buzz");

            Assert.AreEqual(rules.GetNumberAsWholeKeyword(15), "FizzBuzz");
            Assert.AreEqual(rules.GetNumberAsWholeKeyword(30), "FizzBuzz");
            Assert.AreEqual(rules.GetNumberAsWholeKeyword(315), "FizzBuzz");
            Assert.AreEqual(rules.GetNumberAsWholeKeyword(630), "FizzBuzz");

        }

        [TestMethod()]
        public void JazzFuzzTest()
        {
            rules.AddRule(4, "Fuzz");
            rules.AddRule(9, "Jazz");

            Assert.AreEqual(rules.GetNumberAsSingleKeyword(4), "Fuzz");
            Assert.AreEqual(rules.GetNumberAsSingleKeyword(9), "Jazz");

            Assert.AreEqual(rules.GetNumberAsWholeKeyword(36), "FuzzJazz");
            Assert.AreEqual(rules.GetNumberAsWholeKeyword(72), "FuzzJazz");
            Assert.AreEqual(rules.GetNumberAsWholeKeyword(144), "FuzzJazz");
            Assert.AreEqual(rules.GetNumberAsWholeKeyword(288), "FuzzJazz");
        }
    }
}