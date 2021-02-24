using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class Prime
  {
    public static List<int> GetPrimes(int userNumber)
    {
      List<int> Primes = new List<int> { };
      for (int i = 2; i <= userNumber; i++)
      {
        Primes.Add(i);
      }
      return Primes;
    }
  }
}

