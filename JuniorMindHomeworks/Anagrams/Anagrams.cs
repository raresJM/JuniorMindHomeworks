﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrams
{
    [TestClass]
    public class Anagrams
    {
        //        [TestMethod]
        //        public void Test_ABC()
        //        {
        //           Assert.AreEqual(6,returnNoOfAnagrams("ABC"));
        //        }
        //        public int returnNoOfAnagrams(String word)
        //        {
        //
        //        }
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


        [TestMethod]
        public void Test_ReturnOccurencies()
        {
            Assert.AreEqual(1,Test_ReturnOccurencies("a"));
        }
    }
}

