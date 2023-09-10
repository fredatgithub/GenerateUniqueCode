using LibraryHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectHelper
{
  [TestClass]
  public class UnitTestGetNextNumber
  {
    [TestMethod]
    public void TestMethod_GetNextNumber_0()
    {
      char source = '0';
      char expected = '1';
      char result = HelperClass.GetNextNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNextNumber_1()
    {
      char source = '1';
      char expected = '2';
      char result = HelperClass.GetNextNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNextNumber_2()
    {
      char source = '2';
      char expected = '3';
      char result = HelperClass.GetNextNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNextNumber_3()
    {
      char source = '3';
      char expected = '4';
      char result = HelperClass.GetNextNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNextNumber_4()
    {
      char source = '4';
      char expected = '5';
      char result = HelperClass.GetNextNumber(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_GetNextNumber_5()
    {
      char source = '5';
      char expected = '6';
      char result = HelperClass.GetNextNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNextNumber_6()
    {
      char source = '6';
      char expected = '7';
      char result = HelperClass.GetNextNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNextNumber_7()
    {
      char source = '7';
      char expected = '8';
      char result = HelperClass.GetNextNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNextNumber_8()
    {
      char source = '8';
      char expected = '9';
      char result = HelperClass.GetNextNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNextNumber_9()
    {
      char source = '9';
      char expected = 'A';
      char result = HelperClass.GetNextNumber(source);
      Assert.AreEqual(result, expected);
    }
  }
}
