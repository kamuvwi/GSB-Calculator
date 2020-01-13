using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 10;
        private readonly int b = 20;
        private readonly double c = 10.3;
        private readonly double d = 20.2;
        private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07, 5.09, 6.78, 7.21, 8.78, 9.90, 10.12 };
        private readonly int[] arrayB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(30, Addition.Sum(a, b));
        }

        [TestMethod()]
        public void SumDoubleTest()
        {
            Assert.AreEqual(30.5, Addition.Sum(c, d));
        }

        [TestMethod()]
        public void SumDoubleArrayTest()
        {
            Assert.AreEqual(58.059999999999995, Addition.Sum(arrayA));
        }

        [TestMethod()]
        public void SumIntArrayTest()
        {
            Assert.AreEqual(55, Addition.Sum(arrayB));
        }
    }
}