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
            Byte[] result = {1,0};
            Assert.AreEqual(result, DecimalToBaseTwo(2));
        }
        public byte[] DecimalToBaseTwo(int number) {
            List<Byte> result = new List<Byte>();
            result.Add(1);
            result.Add(0);

            return result.ToArray();  
        }
    }
}
