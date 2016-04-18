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
      int currNum = 0;
      while(!Console.KeyAvailable)
      {
        Console.WriteLine(currNum);
        currNum++;
        Thread.Sleep(500);
      }
    } // PrintIntegers

    public void PrintFibonacci()
    {
      int currNum = 1;
      int prevNum1 = 1;
      int prevNum2 = 0;

      // First 2 numbers in Fibonacci sequence
      Console.WriteLine(prevNum2);
      Thread.Sleep(500);
      Console.WriteLine(prevNum1);
      Thread.Sleep(500);

      while (!Console.KeyAvailable)
      {
        Console.WriteLine(currNum);
        Thread.Sleep(500);

        prevNum2 = prevNum1;
        prevNum1 = currNum;
        currNum = prevNum1 + prevNum2;
      }
    } // PrintFibonacci

    public void PrintPrimes()
    {
      // Print first 2 Primes
      Console.WriteLine(2);
      Thread.Sleep(500);
      Console.WriteLine(3);
      Thread.Sleep(500);

      int testInt = 5; // Int to test
      bool isPrime = true;
      
      while (!Console.KeyAvailable)
      {
        if (isPrime)
        {
          Console.WriteLine(testInt);
          Thread.Sleep(500);
        }
        testInt += 2;

        for (int i = testInt-2; i >= 3; i -= 2)
        {
          if (testInt % i == 0)
          {
            isPrime = false;
            break;
          }
          else
          {
            isPrime = true;
          }
        }
      }
    } // PrintPrimes

  } // class
} // namespace
