using Microsoft.VisualStudio.TestTools.UnitTesting;
using basicMath;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Cal x = new Cal();
            double y = x.Add(3.0, 3.0);
            Assert.AreEqual(y, 6.0);
        }
    }
}