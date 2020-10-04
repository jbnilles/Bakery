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
        int amount = Amount;
        int cost = (amount/10) * 28;
        amount %= 10;
        cost  += (amount / 3) * 10;
        cost += (amount % 3) * 5;
        return cost;
      }
  }
}