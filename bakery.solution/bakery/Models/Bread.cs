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
      public int getCost(int amount)
      {
        return 0;
      }
  }
}