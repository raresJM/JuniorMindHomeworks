using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseTwo
{
    [TestClass]
    public class BaseTwo
    {
        [TestMethod]
        public void Test_2_10()
        {
            Assert.AreEqual({'1','0'}, DecimalToBaseTwo(2));
        }
    }
}
