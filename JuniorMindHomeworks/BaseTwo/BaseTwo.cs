﻿using System;
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
            byte[] result = { 1, 1 };
            CollectionAssert.AreEqual(result, DecimalToBaseTwo(3));
        }

        public byte[] DecimalToBaseTwo(int number)
        {
            byte[] result = {1,0};
            
            return result;  
        }
    }
}
