using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class Loto
    {
        [TestMethod]
        public void LotoTest_Factorial_0()
        {
            Assert.AreEqual(1, calculateFactorial(0));
        }
        [TestMethod]
        public void LotoTest_Factorial_1()
        {
            Assert.AreEqual(1, calculateFactorial(1));
        }
        [TestMethod]
        public void LotoTest_Factorial_3()
        {
            Assert.AreEqual(6, calculateFactorial(3));
        }

        public Decimal calculateFactorial(int number)
        {
            Decimal result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = Decimal.Multiply(result, i);
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
        [TestMethod]
        public void LotoTest_Combinations_6_6()
        {
            Assert.AreEqual(1,combinations(6,6));
        }
        [TestMethod]
        public void LotoTest_Combinations_43_0()
        {
            Assert.AreEqual(1, combinations(0, 43));
        }


        [TestMethod]
        public void LotoTest_6_49()
        {
            Assert.AreEqual(Decimal.Divide(1,13983816), lotoOddsCategoryNumbers(6,49,6));
        }

        [TestMethod]
        public void LotoTest_5_40()
        {
            Assert.AreEqual(Decimal.Divide(1, 658008), lotoOddsCategoryNumbers(5, 40, 5));
        }

        [TestMethod]
        public void LotoTest_6_49_5_Numbers()
        {
            Assert.AreEqual(Decimal.Divide(258, combinations(6,49)), lotoOddsCategoryNumbers(6, 49, 5));
        }

        [TestMethod]
        public void LotoTest_6_49_4_Numbers()
        {
            Assert.AreEqual(Decimal.Divide(13545, combinations(6, 49)), lotoOddsCategoryNumbers(6, 49, 4));
        }

        public Decimal lotoOddsCategoryNumbers(int k, int n, int categoryNumbers)
        {
            return
                    Decimal.Divide
                    (
                    Decimal.Multiply(combinations(categoryNumbers, k), combinations(k-categoryNumbers, n - k)),
                    combinations(k, n)
                    );
        }
        
        public Decimal combinations(int k, int n) {
            return Decimal.Divide(simplifiedFactorial(n,k) , calculateFactorial(k));
        }
    }
}
