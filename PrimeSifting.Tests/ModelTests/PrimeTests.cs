using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeTests
  {
    [TestMethod]
    public void GetPrimes_ReturnsSingleItemList_IntList()
    {
      List<int> newList = new List<int> { 1 };
      List<int> result = Prime.GetPrimes(1);
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetPrimes_AddNumbersUpToInputToList_IntList()
    {
      List<int> newList = new List<int> { 1, 2, 3, 4, 5 };
      List<int> result = Prime.GetPrimes(5);
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