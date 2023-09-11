using LibraryHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectHelper
{
  [TestClass]
  public class UnitTestGetNextNumber
  {
    [TestMethod]
    [DataRow('0', '1')]
    [DataRow('1', '2')]
    [DataRow('2', '3')]
    [DataRow('3', '4')]
    [DataRow('4', '5')]
    [DataRow('5', '6')]
    [DataRow('6', '7')]
    [DataRow('7', '8')]
    [DataRow('8', '9')]
    [DataRow('9', 'A')]
    public void TestMethod_Get_Next_Number_all(char source, char expected)
    {
      char result = HelperClass.GetNextNumber(source);
      Assert.AreEqual(expected, result);
    }
  }
}
