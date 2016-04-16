using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathMagician
{
  public class MathMethods
  {

    public void PrintIntegers()
    {
      int integer = 0;
      while(!Console.KeyAvailable)
      {
        Console.WriteLine(integer);
        integer++;
        Thread.Sleep(500);
      }
    }

    public void PrintFibonacci()
    {
      //return 0;
    }

    public void PrintPrimes()
    {
      //return 2;
    }

  }
}
