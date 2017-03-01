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

        [TestMethod]
        public void Test_Factorial()
        {
            Assert.AreEqual(6, calculateFactorial(3));
        }

        public int calculateFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * calculateFactorial(number - 1);
        }

    }
}
