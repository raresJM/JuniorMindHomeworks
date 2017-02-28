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
            Assert.AreEqual('A',returnColumnLetters(1));
        }
        [TestMethod]
        public void ExcelTest_02()
        {
            Assert.AreEqual('Z',returnColumnLetters(26));
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
