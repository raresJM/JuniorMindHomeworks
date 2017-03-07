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
            byte[] result = {0, 1};
            CollectionAssert.AreEqual(result, Not(2));
        }
        [TestMethod]
        public void Test_NOT_0()
        {
            byte[] result = {1};
            CollectionAssert.AreEqual(result, Not(0));
        }
        [TestMethod]
        public void Test_AND_2_2()
        {
            byte[] result = { 1, 0 };
            CollectionAssert.AreEqual(result, And(2,2));
        }

        public List<byte> Not(int number)
        {
            List<byte> result = new List<byte>();
            result = DecimalToBaseTwo(number);
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == 0)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = 0;
                }
            }
            return result;
        }



        public List<byte> DecimalToBaseTwo(int number)
        {
            List<byte> result = new List<byte>();
            if (number == 0)
            {
                result.Add(0);
            }else
            {
                while (number > 0)
                {
                    result.Insert(0, (byte)(number % 2));
                    number = number / 2;
                }
            }
            return result;  
        }
    }
}
