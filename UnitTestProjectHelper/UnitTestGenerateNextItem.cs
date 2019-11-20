using LibraryHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectHelper
{
    [TestClass]
    public class UnitTestGenerateNextItem
    {
        [TestMethod]
        public void TestMethod_GenerateNextItem_0()
        {
            string source = "0";
            string expected = "1";
            string result = HelperClass.GenerateNextItem(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GenerateNextItem_1()
        {
            string source = "1";
            string expected = "2";
            string result = HelperClass.GenerateNextItem(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GenerateNextItem_2()
        {
            string source = "2";
            string expected = "3";
            string result = HelperClass.GenerateNextItem(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GenerateNextItem_3()
        {
            string source = "3";
            string expected = "4";
            string result = HelperClass.GenerateNextItem(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GenerateNextItem_4()
        {
            string source = "4";
            string expected = "5";
            string result = HelperClass.GenerateNextItem(source);
            Assert.AreEqual(result, expected);
        }


        [TestMethod]
        public void TestMethod_GenerateNextItem_5()
        {
            string source = "5";
            string expected = "6";
            string result = HelperClass.GenerateNextItem(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GenerateNextItem_6()
        {
            string source = "6";
            string expected = "7";
            string result = HelperClass.GenerateNextItem(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GenerateNextItem_7()
        {
            string source = "7";
            string expected = "8";
            string result = HelperClass.GenerateNextItem(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GenerateNextItem_8()
        {
            string source = "8";
            string expected = "9";
            string result = HelperClass.GenerateNextItem(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_GenerateNextItem_9()
        {
            string source = "9";
            string expected = "0";
            string result = HelperClass.GenerateNextItem(source);
            Assert.AreEqual(result, expected);
        }


    }
}
