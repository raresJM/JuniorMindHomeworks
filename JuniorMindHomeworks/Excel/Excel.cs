using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel
{
    [TestClass]
    public class Excel
    {
        [TestMethod]
        public void ExcelTest_01()
        {
            Assert.AreEqual("A",returnColumnLetters(1));
        }
        [TestMethod]
        public void ExcelTest_02()
        {
            Assert.AreEqual("Z", returnColumnLetters(26));
        }
        public String returnColumnLetters(int number)
        {
                
        }
    }
}
