using System;
using System.Collections.Generic;
using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Bakery.Tests
{
  [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void AddBreadOrder_addBreadOrderToList_none()
    {
      
      Bread bread = new Bread(5);
      Pastery pastery = new Pastery(5);
      Orders orders = new Orders(bread, pastery);
      
      
      Assert.AreEqual(bread,Orders.OrdersList[0].getBreadOrder());

    }
    [TestMethod]
    public void AddPasteryOrder_addPasteryOrderToList_none()
    {
      Bread bread = new Bread(5);
      Pastery pastery = new Pastery(5);
      Orders orders = new Orders(bread, pastery);
       Assert.AreEqual(pastery,Orders.OrdersList[0].getPasteryOrder());

    }
    
    
  }
}