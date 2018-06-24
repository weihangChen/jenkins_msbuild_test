using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            ClassLibrary1.Class1 tmp = new ClassLibrary1.Class1();
            Assert.IsTrue(1 == 1);
        }
    }
}
