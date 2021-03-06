﻿using System;
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
      
      MathMethods mathMethods = new MathMethods();
      int userChoice;
      bool choiceMade = false;

      Console.WriteLine("\n1. Print Integers");
      Console.WriteLine("2. Print Fibonacci Sequence");
      Console.WriteLine("3. Print Prime Numbers");
      Console.WriteLine("\nI am the Math Magician. What would you like me to do?");
      Console.Write("> ");

      Int32.TryParse(Console.ReadLine(), out userChoice);

      while (choiceMade == false)
      {
        switch (userChoice)
        {
          case 1:
            Console.WriteLine("Every Integer:");
            mathMethods.PrintIntegers();
            choiceMade = true;
            break;
          case 2:
            Console.WriteLine("Fibonacci Sequence:");
            mathMethods.PrintFibonacci();
            choiceMade = true;
            break;
          case 3:
            Console.WriteLine("Every Prime Number:");
            mathMethods.PrintPrimes();
            choiceMade = true;
            break;
          default:
            Console.WriteLine("Invalid Choice. Please type a number.");
            Console.Write("> ");
            Int32.TryParse(Console.ReadLine(), out userChoice);
            break;
        }
      }
      
    }
  }
}
