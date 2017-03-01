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
            Assert.AreEqual(13983816, kOfn(6,49));
        }
        [TestMethod]
        public void LotoTest_5_40()
        {
            Assert.AreEqual(658008, kOfn(5,40));
        }
        public BigInteger sixOffortyNine() {
            BigInteger result = new BigInteger(0);
            result = BigInteger.Divide(
                calculateFactorial(49),
                (BigInteger.Multiply(calculateFactorial(6),calculateFactorial(49 - 6))));
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
