using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BaseTwo
{
    [TestClass]
    public class BaseTwo
    {
        [TestMethod]
        public void Test_2_10()
        {
            byte[] result = {1,0};
            CollectionAssert.AreEqual(result, DecimalToBaseTwo(2));
        }
        [TestMethod]
        public void Test_3_11()
        {
            byte[] result = {1,1};
            CollectionAssert.AreEqual(result, DecimalToBaseTwo(3));
        }
        [TestMethod]
        public void Test_NOT_2()
        {
            byte[] result = { 0, 1 };
            CollectionAssert.AreEqual(result, Not(2));
        }

        public List<byte> Not(int number)
        {
            List<byte> result = new List<byte>();
            result.Insert(0, 0);
            result.Insert(1, 1);
            return result;
        }



        public List<byte> DecimalToBaseTwo(int number)
        {
            List<byte> result = new List<byte>();
            while (number > 0)
            {
                result.Insert(0, (byte)(number % 2));
                number = number / 2;
            }
            return result;  
        }
    }
}
