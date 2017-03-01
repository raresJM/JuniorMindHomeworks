using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace Anagrams
{
    [TestClass]
    public class Anagrams
    {

        [TestMethod]
        public void AnagramTest_ABC()

        {
            Assert.AreEqual(6,returnNoOfAnagrams("ABC"));
        }

        [TestMethod]
        public void AnagramTest_AA()

        {
            Assert.AreEqual(1, returnNoOfAnagrams("AA"));
        }

        [TestMethod]
        public void AnagramTest_AAA()

        {
            Assert.AreEqual(1, returnNoOfAnagrams("AAA"));
        }

        [TestMethod]
        public void AnagramTest_ABCDA()

        {
            Assert.AreEqual(60, returnNoOfAnagrams("ABCDA"));
        }

        [TestMethod]
        public void AnagramTest_ABCDAAAAAAAA()

        {
            Assert.AreEqual(1320, returnNoOfAnagrams("ABCDAAAAAAAA"));
        }

        public int returnNoOfAnagrams(String word)
        {
            return calculateFactorial(word.Length) / calculateDenominator(word);
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

        public int calculateDenominator(String word)
        {
            int count = 1;
            int denominator = 1;

            char[] chars = word.ToCharArray();
            Array.Sort(chars);

            for (int i = 0; i< chars.Length-1; i++)
            {
                if (chars[i] == chars[i + 1])
                {
                    count++;
                    denominator *= count;
                }
                else
                {
                    count = 1;
                }
            }
            return denominator;
        }
    }
}

