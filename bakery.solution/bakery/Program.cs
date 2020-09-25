using System;
using Bakery.Models;


namespace Bakery
{
  public class Program
  {
     public static void Main() 
    {
      string line = "";
      int numBread = 0;
      int numPasteries = 0;
      int orderCost = 0;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      while (line.ToLower() != "exit")
      {
        Console.WriteLine("Enter 'menu' to bring up the menu, enter 'order' to begin/edit your order, enter 'buy' to complete purchase or enter 'exit' to exit the program");
        line = Console.ReadLine();
        switch (line.ToLower())
        {
            case "menu":
              Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
              Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");
              break;
            case "order":
              Console.WriteLine("Enter amount of Pasteries you want to buy:");
              string strPasteries = Console.ReadLine();
              Console.WriteLine("Enter amount of Bread you want to buy:");
              string strBread = Console.ReadLine();
              if(int.TryParse(strBread, out numBread) && int.TryParse(strPasteries, out numPasteries))
              {
                Bread bread = new Bread(numBread);
                Pastery  pastery = new Pastery(numPasteries);
                orderCost = bread.getCost() + pastery.getCost();
                Console.WriteLine("You order has {0} Bread", numBread);
                Console.WriteLine("You order has {0} Pasteries", numPasteries);
                Console.WriteLine("Total Cost ${0} ", orderCost);
                Console.WriteLine();
                break;
              }
              goto default;
            case "buy":
              Console.WriteLine("Thank you for your order of:");
              Console.WriteLine("You order has {0} Bread", numBread);
              Console.WriteLine("You order has {0} Pasteries", numPasteries);
              Console.WriteLine("Total Cost ${0} ", orderCost);
              numBread = 0;
              numPasteries = 0;
              orderCost = 0;
              break;
            case "exit":
              break;
            default:
              Console.WriteLine("There was an error in your input. Please try again.");
              break;
        }
      }
      // Console.WriteLine("Welcome to Pierre's Bakery! Type Menu to bring up the menu, type order to place order or Type exit to exit the program");
      // while((line = Console.ReadLine()).ToLower() != "exit")
      // {
      //   if(line.ToLower() == "menu")
      //   {
      //     Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
      //     Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");
      //   }
      //   else if (line.ToLower() == "order") 
      //   {
      //     Console.WriteLine("Enter number of Bread:");
      //     string strBread = Console.ReadLine();
      //     int numBread;
      //     int numPasteries;
      //     if(int.TryParse(strBread, out numBread))
      //     {
      //       Console.WriteLine("Enter number of Pasteries:");
      //       string strPasteries = Console.ReadLine();
      //       if(int.TryParse(strPasteries, out numPasteries))
      //       {
      //         Bread bread = new Bread(numBread);
      //         Pastery  pastery = new Pastery(numPasteries);
      //         int orderCost = bread.getCost() + pastery.getCost();
      //         Console.WriteLine("You ordered {0} Bread", numBread);
      //         Console.WriteLine("You ordered {0} Pasteries", numPasteries);
      //         Console.WriteLine("Total Cost ${0} ", orderCost);
      //         Console.WriteLine();
      //         Console.WriteLine("Type edit to change order or type buy to complete order and purchase.", orderCost);
      //         if((line = Console.ReadLine()).ToLower() == "edit")
      //         {
      //           Console.WriteLine("edit");
      //         }
      //         else if (line.ToLower() == "buy")
      //         {
      //           Console.WriteLine("buy");
      //         }
      //         else
      //         {
      //           Console.WriteLine("user error");
      //         }
              
              
      //       }
      //       else
      //       {
      //         Console.WriteLine("There was an error in your input. Please try again.");
      //         Console.WriteLine(" Type Menu to bring up the menu, type order to place order or Type exit to exit the program");
      //       }
      //     }
      //     else
      //     {
      //       Console.WriteLine("There was an error in your input. Please try again.");
      //       Console.WriteLine(" Type Menu to bring up the menu, type order to place order or Type exit to exit the program");
      //     }
          

      //   }
      //   else
      //     {
      //       Console.WriteLine("There was an error in your input. Please try again.");
      //       Console.WriteLine(" Type Menu to bring up the menu, type order to place order or Type exit to exit the program");
      //     }
      // }
    } 
  }
  
    
}


