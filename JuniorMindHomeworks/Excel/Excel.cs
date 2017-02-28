using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel
{
    [TestClass]
    public class Excel
    {
        [TestMethod]
        public void ExcelTest_A()
        {
            Assert.AreEqual('A',returnColumnLetters(1));
        }
        [TestMethod]
        public void ExcelTest_Z()
        {
            Assert.AreEqual('Z',returnColumnLetters(26));
        }
        [TestMethod]
        public void ExcelTest_AA()
        {
            Assert.AreEqual('AA', returnColumnLetters(27));
        }

        public char returnColumnLetters(int number)
        {
            char[] chars = new char[26];
            for (int i = 0; i < 26; i++)
            {
                chars[i] = (char)('A' + i);
            }
            return chars[number-1];         
        }
    }
}
