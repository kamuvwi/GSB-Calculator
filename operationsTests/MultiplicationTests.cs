using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly int a = 20;
        private readonly int b = 10;
        private readonly double c = 20.3;
        private readonly double d = 10.2;
        private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07, 5.09, 6.78, 7.21, 8.78, 9.90, 10.12 };
        private readonly int[] arrayB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(200, Multiplication.Multiply(a, b));
        }

        [TestMethod()]
        public void MultiplyDoubleTest()
        {
            Assert.AreEqual(207.06, Multiplication.Multiply(c, d));
        }

        [TestMethod()]
        public void MultiplyDoubleArrayTest()
        {
            Assert.AreEqual(5616429.875755116, Multiplication.Multiply(arrayA));
        }

        [TestMethod()]
        public void MultiplyIntArrayTest()
        {
            Assert.AreEqual(3628800, Multiplication.Multiply(arrayB));
        }
    }
}