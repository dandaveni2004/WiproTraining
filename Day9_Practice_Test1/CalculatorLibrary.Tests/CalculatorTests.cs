using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;

namespace CalculatorLibrary.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Add_ReturnsCorrectResult()
        {
            Assert.AreEqual(15, calculator.Add(10, 5));
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectResult()
        {
            Assert.AreEqual(5, calculator.Subtract(10, 5));
        }

        [TestMethod]
        public void Multiply_ReturnsCorrectResult()
        {
            Assert.AreEqual(50, calculator.Multiply(10, 5));
        }

        [TestMethod]
        public void Divide_ReturnsCorrectResult()
        {
            Assert.AreEqual(2, calculator.Divide(10, 5));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsException()
        {
            calculator.Divide(10, 0);
        }
    }
}