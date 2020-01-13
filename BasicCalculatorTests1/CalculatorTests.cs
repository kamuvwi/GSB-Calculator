﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Add(1, 2);

            Assert.AreEqual(3, c);
            Assert.AreEqual(3, calculator.result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Divide(2, 1);

            Assert.AreEqual(2, c);
            Assert.AreEqual(2, calculator.result);
        }

        [TestMethod()]
        public void DivideIntDivideZeroTest()
        {
            Calculator calculator = new Calculator();

            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(2, 0));
        }

        [TestMethod()]

        public void AddIntDoubleTest()
        {
            Calculator calculator = new Calculator();
            int a = 1;
            double b = 2.02;
            double c = calculator.Add(a, b);

            Assert.AreEqual(3.02, c);
            Assert.AreEqual(3.02, calculator.result);

        }
    }
}