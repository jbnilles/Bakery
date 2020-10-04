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
        int amount = Amount;
        int cost = (amount/10) * 14;
        amount %= 10;
        cost += (amount / 3) * 5;
        cost += (amount % 3) * 2;
        return cost;
      }
  }
}