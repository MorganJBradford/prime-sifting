using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class Prime
  {
    public static List<int> GetPrimes(int userNumber)
    {
      List<int> Primes = new List<int> { userNumber };
      return Primes;
    }
  }
}