using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      int num1;
      int num2;
      string operation;
      int result;

      while(true)
      {

      
      Console.WriteLine("Welcome to the calculator");
      
      Console.WriteLine("What operation do you want to do?");

      System.Console.WriteLine("A: addition,\nS: substraction,\nM: multiplication,\nX: Stop program\nAny other key: division");

      operation = Console.ReadLine();

      if(operation == "x")
      {
        break;
      }

      Console.WriteLine("Enter first number");

      num1 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter second number");

      num2 = Convert.ToInt32(Console.ReadLine());

      if(operation == "a")
      {
        result = num1 + num2;
      } else if (operation == "s")
      {
        result = num1 - num2;
      } else if (operation == "m")
      {
        result = num1 * num2;
      } 
      else
      {
        result = num1/num2;
      }

      System.Console.WriteLine($"The result is {result}");
      System.Console.WriteLine("...");
      System.Threading.Thread.Sleep(1000);
      }
    }
  }
}