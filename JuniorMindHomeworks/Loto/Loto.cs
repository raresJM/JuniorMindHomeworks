using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class Loto
    {
        [TestMethod]
        public void LotoTest_6_49()
        {
            Assert.AreEqual(13983816, kOfN(6,49));
        }
        [TestMethod]
        public void LotoTest_5_40()
        {
            Assert.AreEqual(658008, kOfN(5,40));
        }
        public BigInteger kOfN(int k, int n) {
            BigInteger result = new BigInteger(0);
            result = BigInteger.Divide(
                calculateFactorial(n),
                (BigInteger.Multiply(calculateFactorial(k),calculateFactorial(n - k))));
            return result;
        }


        [TestMethod]
        public void Test_Factorial()
        {
            Assert.AreEqual(6, calculateFactorial(3));
        }

        public BigInteger calculateFactorial(int number)
        {
            BigInteger result = new BigInteger(1);
            for (int i = 1; i <= number; i++)
            {
                result = BigInteger.Multiply(result, i);
            }
            return result;
        }

    }
}
