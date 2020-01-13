using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 20;
        private readonly int b = 10;
        private readonly double c = 20.3;
        private readonly double d = 10.2;

        [TestMethod()]
        public void DifferenceTest()
        {
            Assert.AreEqual(10, Subtraction.Difference(a, b));
        }

        [TestMethod()]
        public void DifferenceDoubleTest()
        {
            Assert.AreEqual(10.100000000000001, Subtraction.Difference(c, d));
        }
    }
}