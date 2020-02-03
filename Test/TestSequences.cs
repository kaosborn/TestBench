using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sequences;

namespace Test
{
    [TestClass]
    public class TestSequences
    {
        [TestMethod]
        public void TestOdd()
        {
            int expected = 1;
            foreach (int actual in Numbers.GetOddDigitsLessThan (8))
            {
                Assert.AreEqual (expected, actual);
                expected += 2;
            }

            Assert.AreEqual (9, expected);
        }
    }
}
