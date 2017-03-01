using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class Loto
    {
        [TestMethod]
        public void LotoTest_6_49()
        {
            Assert.AreEqual(13983816, 6_Of_49());
        }
    }
}
