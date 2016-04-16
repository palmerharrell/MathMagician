using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician;

namespace MathMagicianTESTS
{
  [TestClass]
  public class UnitTest1
  {
    MathMethods test = new MathMethods();

    [TestMethod]
    public void TestFirstInteger()
    {
      Assert.IsTrue(test.PrintIntegers() == 0);
    }

    [TestMethod]
    public void TestFirstFibonacci()
    {
      Assert.IsTrue(test.PrintFibonacci() == 0);
    }

    [TestMethod]
    public void TestFirstPrimes()
    {
      Assert.IsTrue(test.PrintPrimes() == 2);
    }
  }
}
