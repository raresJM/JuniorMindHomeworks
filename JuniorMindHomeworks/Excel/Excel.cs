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
            Assert.AreEqual("A", convertDecimalTo26Base(1));
        }
        [TestMethod]
        public void ExcelTest_Z()
        {
            Assert.AreEqual("Z", convertDecimalTo26Base(26));
        }
        [TestMethod]
        public void ExcelTest_AA()
        {
            Assert.AreEqual("AA", convertDecimalTo26Base(27));
        }
        [TestMethod]
        public void ExcelTest_AZ()
        {
            Assert.AreEqual("AZ", convertDecimalTo26Base(52));
        }

        [TestMethod]
        public void ExcelTest_ZZ()
        {
            Assert.AreEqual("ZZ", convertDecimalTo26Base(702));
        }
        [TestMethod]
        public void ExcelTest_AAA()
        {
            Assert.AreEqual("AAA", convertDecimalTo26Base(703));
        }
        [TestMethod]
        public void ExcelTest_ABC()
        {
            Assert.AreEqual("ABC", convertDecimalTo26Base(731));
        }
        [TestMethod]
        public void ExcelTest_ABZ()
        {
            Assert.AreEqual("ABZ", convertDecimalTo26Base(754));
        }
        [TestMethod]
        public void ExcelTest_AMJ()
        {
            Assert.AreEqual("AMJ", convertDecimalTo26Base(1024));
        }
        public String convertDecimalTo26Base(int columnNumber)
        {
            String result = "";
            while (columnNumber > 0)
            {
                columnNumber--;
                result = (char)('A' + columnNumber % 26) + result;
                columnNumber = columnNumber / 26;
            }
            return result;
        }
            
        }
    }
