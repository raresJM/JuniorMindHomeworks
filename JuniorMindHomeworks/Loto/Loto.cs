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
            Assert.AreEqual(Decimal.Divide(1,13983816), Decimal.Divide(1, combinations(6,49)));
        }

        [TestMethod]
        public void LotoTest_5_40()
        {
            Assert.AreEqual(Decimal.Divide(1, 658008), Decimal.Divide(1, combinations(5, 40)));
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
            int categoryValue = 0;
            switch (categoryNumbers)
            {
                case 5:
                    {
                        categoryValue = 1; break;
                    }
                case 4:
                    {
                        categoryValue = 2; break;
                    }
                default:
                    {
                        //throw exception
                        break;  
                    } 
            }

            return
                    Decimal.Divide
                    (
                    Decimal.Multiply(combinations(categoryNumbers, k), combinations(categoryValue, n - k)),
                    combinations(k, n)
                    );
        }
        
        public Decimal combinations(int k, int n) {
            return  simplifiedFactorial(n,k) / calculateFactorial(k);
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
