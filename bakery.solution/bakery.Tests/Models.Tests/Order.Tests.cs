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
      Orders orders = new Orders();
      Bread bread = new Bread(5);
      orders.addBreadOrder(bread);
      List<Bread> breadList = orders.getBreadOrderList();
      Assert.AreEqual(bread,breadList[0]);

    }
    [TestMethod]
    public void AddBreadOrder_addPasteryOrderToList_none()
    {
      Orders orders = new Orders();
      Pastery pastery = new Pastery(5);
      orders.addPasteryOrder(pastery);
      List<Pastery> pasteryList = orders.getPasteryOrderList();
      Assert.AreEqual(pastery,pasteryList[0]);

    }
    [TestMethod]
    public void RemoveBreadOrder_addBreadOrderToList_none()
    {
      Orders orders = new Orders();
      Bread bread = new Bread(5);
      orders.addBreadOrder(bread);
      orders.removeBreadListItem(bread);
      List<Bread> breadList = orders.getBreadOrderList();
      Assert.AreEqual(0,breadList.Count);

    }
    [TestMethod]
    public void RemovePasteryOrder_addPasteryOrderToList_none()
    {
      Orders orders = new Orders();
      Pastery pastery = new Pastery(5);
      orders.addPasteryOrder(pastery);
      orders.removePasteryListItem(pastery);
      List<Pastery> pasteryList = orders.getPasteryOrderList();
      Assert.AreEqual(0,pasteryList.Count);

    }
  }
}