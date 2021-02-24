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
      List<int> newList = new List<int> { 2 };
      List<int> result = Prime.GetPrimes(2);
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetPrimes_AddNumbersUpToInputToList_IntList()
    {
      List<int> newList = new List<int> { 2, 3, 4, 5 };
      List<int> result = Prime.GetPrimes(5);
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetPrimes_FilterPrimeNumbersFromList_IntList()
    {
      List<int> newList = new List<int> { 2, 3, 5, 7 };
      List<int> result = Prime.GetPrimes(10);
      CollectionAssert.AreEqual(newList, result);
    }
  }
}




// starting list 6

// prime list 2 3

// if (index % primelist == 0)
// restart loop with next index

// else
// primelist.add index