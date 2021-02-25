using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number and see a list of prime numbers up to your number:");
      int userNumber = int.Parse(Console.ReadLine());
      List<int> response = Prime.GetPrimes(userNumber);
      Console.WriteLine("----------------");
      foreach (int number in response)
      {
        Console.WriteLine(number);
      }
    }
  }
}