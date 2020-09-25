using System;
using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Bakery.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
       public void getCost_ReturnCost_int(){
        Bread bread = new Bread(7);
        Assert.AreEqual(25,bread.getCost());
       //Assert.AreEqual("nineteen",Words.getNumWordRecursive(999999999999));
      }
  }
}