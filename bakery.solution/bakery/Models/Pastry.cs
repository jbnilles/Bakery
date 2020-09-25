using System;

namespace Bakery.Models
{
  public class Pastery
  {
    public int Amount { get; set; }
    
    public Pastery(int amount)
    {
      Amount = amount;
    }
      public int getCost()
      {
        int cost = (Amount / 3) * 5;
        cost += (Amount % 3) * 2;
        return cost;
      }
  }
}