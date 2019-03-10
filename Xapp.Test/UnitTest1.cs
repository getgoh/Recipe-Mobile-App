using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Xapp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void when2NumbersThenShouldReturnSum()
        {
            Assert.AreEqual(3 + 6, add2numbers(3, 6));
        }

        public int add2numbers(int x, int y)
        {
            return x + y;
        }
    }
}
