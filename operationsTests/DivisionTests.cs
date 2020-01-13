using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 20;
        private readonly int b = 10;
        private readonly double c = 20.3;
        private readonly double d = 10.2;
        private readonly int e = 0;

        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(2, Division.Divide(a, b));
        }

        [TestMethod()]
        public void DivideDoubleTest()
        {
            Assert.AreEqual(1.9901960784313728, Division.Divide(c, d));
        }

        [TestMethod()]
        public void DivideIntDivideZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Divide(a, e));
        }
    }
}