using LibraryHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectHelper
{
  [TestClass]
  public class UnitTestGenerateSequence
  {
    [TestMethod]
    public void TestMethod_GenerateSequence_a()
    {
      string result = HelperClass.GenerateSequence();
      Assert.IsTrue(result.Length > 0);
    }
  }
}
