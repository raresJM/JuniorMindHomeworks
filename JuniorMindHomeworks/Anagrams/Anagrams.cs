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

        public void Test_ABC()

        {

            Assert.AreEqual(6,returnNoOfAnagrams("ABC"));

        }

        public int returnNoOfAnagrams(String word)

        {
            foreach (char character in word.ToCharArray())

            {

            }

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


        [TestMethod]
        public void Test_ReturnOccurencies()
        {
            Assert.AreEqual(1,returnOccurencies('a', "abc"));
        }

        public int returnOccurencies(char c, String word)
        {
            int result = 0;
            ArrayList chars = new ArrayList();
            chars.AddRange(word.ToCharArray());

            for (int i = 0; i< chars.Count; i++)
            {
                if (chars[i].Equals(c)) {
                    if (result > 1) {
                        chars.RemoveAt(i);
                    }
                    result++;
                }
            }
            return result;
        }

    }
}

