using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; set; }
    
    public Bread(int amount)
    {
      Amount = amount;
    }
      public int getCost()
      {
        int cost  = (Amount / 3) * 10;
        cost += (Amount % 3) * 5;
        return cost;
      }
  }
}