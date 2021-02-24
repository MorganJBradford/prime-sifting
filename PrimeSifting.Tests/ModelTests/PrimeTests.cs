using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeTests
  {
    [TestMethod]
    public void GetPrimes_ReturnsEmptyList_IntList()
    {
      List<int> newList = new List<int> { };
      List<int> result = Prime.GetPrimes();
      CollectionAssert.AreEqual(newList, result);
    }

    // [TestMethod]
    // public void GetPrimes_OneIsNotPrime_ExpectedReturnValue()
    // {
    //   any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    //   Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    // }
  }
}