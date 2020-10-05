using System;
using Bakery.Models;


namespace Bakery
{
  public class Program
  {
    public static void printMenu()
    {
      Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5 or buy 10 for $28. ");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5 or buy 10 for $14.");
      return;
    }
    public static Bread getBreadOrder()
    {
      int numBread;
      Console.WriteLine("Enter amount of Bread you want to buy:");
      string strBread = Console.ReadLine();
      if(int.TryParse(strBread, out numBread))
      {
        return new Bread(numBread);
      }
      return null;
    }
    public static Pastery getPasteryOrder()
    {
      int numPasteries = 0;
      Console.WriteLine("Enter amount of Pasteries you want to buy:");
      string strPasteries = Console.ReadLine();
      if(int.TryParse(strPasteries, out numPasteries))
      {
        return new Pastery(numPasteries);
      }
      return null;
    }
    public static void writePreOrderDetails(Bread b, Pastery p)
    {

      Console.WriteLine("Your order has {0} Bread", b.Amount);
      Console.WriteLine("Your order has {0} Pasteries", p.Amount);
      Console.WriteLine("Total Cost ${0} ", b.getCost() + p.getCost());
      Console.WriteLine();
    }
    public static void writeAllOrdersDetails()
    {
      Console.WriteLine("You made a total of {0} Orders", Orders.OrdersList.Count);
      int i = 1;
      foreach (Orders order in Orders.OrdersList)
      {
        Console.WriteLine("Order {0}: ", i);
        Console.WriteLine("Amount of bread: {0} ", order.getBreadOrder().Amount);
        Console.WriteLine("Amount of pasteries: {0} ", order.getPasteryOrder().Amount);
        Console.WriteLine("Cost: ${0} ", order.OrderCost);
        i++;
      }
    }
    
     public static void Main() 
    {
      string line = "";
      Bread bread = null;
      Pastery pastery = null;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      while (line.ToLower() != "exit")
      {
        
        Console.WriteLine("Enter 'menu' to bring up the menu, enter 'order' to begin/edit your order, enter 'buy' to complete purchase or enter 'exit' to exit the program");
        line = Console.ReadLine();
        switch (line.ToLower())
        {
            case "menu":
              printMenu();
              break;
            case "order":
              bread = getBreadOrder();
              pastery = getPasteryOrder();
              if(bread == null || pastery == null)
              {
                goto default;
              }
              writePreOrderDetails(bread, pastery);
              break;
              
            case "buy":
              if(bread != null && pastery != null)
              {
                Console.WriteLine("Thank You For Your Puchase Of:");
                writePreOrderDetails(bread, pastery);
                new Orders(bread, pastery);
                bread = null;
                pastery = null;
                break;
              }
              else
              {
                Console.WriteLine("There was an error. You have no items in your order please. Please try again.");
                break;
              }
              
            case "exit":
              writeAllOrdersDetails();
              break;
              
            default:
              Console.WriteLine("There was an error in your input. Please try again.");
              break;
        }
      }
    } 
  }
  
    
}


