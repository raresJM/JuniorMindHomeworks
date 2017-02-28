using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
