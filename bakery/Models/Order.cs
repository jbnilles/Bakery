using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class Orders
  {
    public int OrderCost { get; set; }
    
    public static List<Orders> OrdersList = new List<Orders>{};
    private Bread breadOrder;
    private Pastery pasteryOrder;
    public Orders(Bread b, Pastery p)
    {
      breadOrder = b;
      pasteryOrder = p;
      UpdateOrderCost();
      OrdersList.Add(this);
    }
    private void UpdateOrderCost()
    {
      OrderCost = breadOrder.getCost() + pasteryOrder.getCost();
    }
    public void EditBreadOrder(Bread b)
    {
      breadOrder = b;
      UpdateOrderCost();
    }
    public void EditPasteryOrder(Pastery p)
    {
      pasteryOrder = p;
      UpdateOrderCost();
    }
    public Bread getBreadOrder()
    {
      return breadOrder;

    }
    public Pastery getPasteryOrder()
    {
      return pasteryOrder;
    }
    public static void RemoveOrder(Orders o)
    {
      OrdersList.Remove(o);
    }
    
  }
}