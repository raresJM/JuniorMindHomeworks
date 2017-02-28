using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TenToTwoConversion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("11",convertTenTwo(2));

        }
        public String convertTenTwo(int nr)
        {
            String result = "";
            while (nr != 0)
            {
                result = nr % 2 + result;
                nr = nr / 2;
            }
            return result;
        }
    }
}
