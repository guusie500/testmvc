using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();

            Assert.AreEqual(1, p.TestTest());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Program p = new Program();

            Assert.AreEqual(1, p.TestTest());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Program p = new Program();

            Assert.AreEqual(1, p.TestTest());
        }
    }
}
