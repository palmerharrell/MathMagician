using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician;

namespace MathMagicianTESTS
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestPrintIntegers()
    {
      MathMethods test = new MathMethods();
      Assert.IsTrue(test.PrintIntegers() == 1);
    }
  }
}
