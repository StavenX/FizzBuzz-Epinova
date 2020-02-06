using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz_Epinova;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_Epinova.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        private IMathGame _fizzBuzz = new FizzBuzz();
        private IMathGame _jazzFuzz = new JazzFuzz();

        [TestMethod()]
        public void TestFizzBuzz()
        {
            Assert.AreEqual(_fizzBuzz.GetNumberAsKeyword(3), "Fizz");
            Assert.AreEqual(_fizzBuzz.GetNumberAsKeyword(5), "Buzz");
            Assert.AreEqual(_fizzBuzz.GetNumberAsKeyword(15), "FizzBuzz");
        }

        [TestMethod()]
        public void TestJazzFuzz()
        {
            Assert.AreEqual(_jazzFuzz.GetNumberAsKeyword(9), "Jazz");
            Assert.AreEqual(_jazzFuzz.GetNumberAsKeyword(4), "Fuzz");
            Assert.AreEqual(_jazzFuzz.GetNumberAsKeyword(36), "JazzFuzz");
        }
    }
}