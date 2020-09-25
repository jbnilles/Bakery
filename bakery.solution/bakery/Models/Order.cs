using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class Orders
  {
    public int OrderCost { get; set; }
    public int AmountBread { get; set; }
    public int AmountPasdtries { get; set; }
    private List <Bread> breadOrders;
    private List <Pastery> pasteryOrders;
    public void addBreadOrder(Bread b)
    {
      breadOrders.Add(b);
    }
    public void addPasteryOrder(Pastery p)
    {
      pasteryOrders.Add(p);
    }
    public List<Bread> getBreadOrderList()
    {
      return breadOrders;
    }
    public List<Pastery> getBreadOrderList()
    {
      return pasteryOrders;
    }
    public Bread removeBreadListItem(Bread b)
    {
      breadOrders.Remove(b);
    }
    public Pastery removePasteryListItem(Pastery p)
    {
      pasteryOrders.Remove(p);
    }
  }
}