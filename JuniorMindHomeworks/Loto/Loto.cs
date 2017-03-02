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
            Assert.AreEqual(Decimal.Divide(1,13983816), lotoOdds(6, 49));
        }

        [TestMethod]
        public void LotoTest_6_49_5_Numbers()
        {
            Assert.AreEqual(Decimal.Divide(1, (Decimal)54200.8), lotoOddsCategoryOne(6, 49));
        }


        [TestMethod]
        public void LotoTest_5_40()
        {
            Assert.AreEqual(Decimal.Divide(1,658008), lotoOdds(5,40));
        }

        public Decimal lotoOdds(int k, int n) {
            return calculateFactorial(k) / simplifiedFactorial(n,k);
        }

        [TestMethod]
        public void Test_Factorial()
        {
            Assert.AreEqual(6, calculateFactorial(3));
        }

        public Decimal calculateFactorial(int number)
        {
            Decimal result = 1;
            for (int i = 1; i <= number; i++)
            {
                result= Decimal.Multiply(result,i);
            }
            return result;
        }

        public Decimal simplifiedFactorial(int n, int k)
        {
            Decimal result = 1;
            for (int i = n; i > (n - k); i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
