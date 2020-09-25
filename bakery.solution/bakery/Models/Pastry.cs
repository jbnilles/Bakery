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
      public int getCost(int amount)
      {
        return 0;
      }
  }
}