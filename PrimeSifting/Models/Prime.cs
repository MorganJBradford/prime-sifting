using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class Prime
  {
    public static List<int> GetPrimes(int userNumber)
    {
      List<int> intList = new List<int> { };
      List<int> primeList = new List<int> { };
      for (int i = 2; i <= userNumber; i++)
      {
        intList.Add(i);
        primeList.Add(i);
      }
      foreach (int number in intList)
      {
        foreach (int otherNumber in intList)
        {
          if (number > otherNumber)
          {
            if (number % otherNumber == 0)
            {
              primeList.Remove(number);
            }
          }
        }
      }
      return primeList;
    }
  }
}