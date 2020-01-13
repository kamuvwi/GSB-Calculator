using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class RandomisingTests
    {
        private readonly int min = 5;
        private readonly int max = 10;
        Randomising rand = new Randomising();
        Randomising rand1 = new Randomising();

        [TestMethod()]
        public void RandomiseTest()
        {
            Assert.AreEqual(rand.Randomise(min, max), rand1.Randomise(min, max));
        }
    }
}