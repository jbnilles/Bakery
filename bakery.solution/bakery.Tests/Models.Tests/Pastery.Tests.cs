using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
namespace Bakery.Tests
{
  [TestClass]
  public class PasteryTest
  {

      [TestMethod]
       public void AmmountProperty_ReturnAmmount_int(){
        Pastery pastery = new Pastery(7);
        Assert.AreEqual(7,pastery.Amount);
       //Assert.AreEqual("nineteen",Words.getNumWordRecursive(999999999999));
      }
      [TestMethod]
       public void getCost_ReturnCost_int(){
        Pastery pastery = new Pastery(7);
        Assert.AreEqual(12,pastery.getCost());
       //Assert.AreEqual("nineteen",Words.getNumWordRecursive(999999999999));
      }
  }
}