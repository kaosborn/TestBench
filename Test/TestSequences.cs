using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sequences;

namespace Test
{
    [TestClass]
    public class TestSequences
    {
        [TestMethod]
        public void Case1()
        {
            int expected = 0;
            foreach (int actual in Numbers.GetSingleDigitNumbers())
            {
                Assert.AreEqual (expected, actual);
                expected++;
            }

            Assert.AreEqual (10, expected);
        }
    }
}
