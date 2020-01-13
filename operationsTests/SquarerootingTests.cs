using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class SquarerootingTests
    {
        private readonly int a = 25;
        private readonly double b = 10.8;

        [TestMethod()]
        public void SquarerootTest()
        {
            Assert.AreEqual(5, Squarerooting.Squareroot(a));
        }
    }
}