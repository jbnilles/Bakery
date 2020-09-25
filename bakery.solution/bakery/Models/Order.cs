using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class Orders
  {
    public int OrderCost { get; set; }
    public int AmountBread { get; set; }
    public int AmountPastries { get; set; }
    private List <Bread> breadOrders;
    private List <Pastery> pasteryOrders;
    public Orders()
    {
      breadOrders = new List<Bread>();
      pasteryOrders = new List<Pastery>();
    }
    public void addBreadOrder(Bread b)
    {
      breadOrders.Add(b);
      AmountBread++;
    }
    public void addPasteryOrder(Pastery p)
    {
      pasteryOrders.Add(p);
      AmountPastries++;
    }
    public List<Bread> getBreadOrderList()
    {
      AmountBread--;
      return breadOrders;

    }
    public List<Pastery> getPasteryOrderList()
    {
      AmountPastries--;
      return pasteryOrders;
    }
    public void removeBreadListItem(Bread b)
    {
      breadOrders.Remove(b);
    }
    public void removePasteryListItem(Pastery p)
    {
      pasteryOrders.Remove(p);
    }
  }
}