using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathMagician
{
  class Program
  {
    static void Main(string[] args)
    {
      while (!Console.KeyAvailable) // Loop until any key is pressed
      {
        Console.WriteLine("Still going...");
        Thread.Sleep(500);
      }
    }
  }
}
