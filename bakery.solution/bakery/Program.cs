using System;
using Bakery.Models;


namespace Bakery
{
  public class Program
  {
     public static void Main() 
    {
      string line = "";
      Console.WriteLine("Welcome to Pierre's Bakery! Type Menu to bring up the menu, type order to place order or Type exit to exit the program");
      while((line = Console.ReadLine()).ToLower() != "exit")
      {
        if(line.ToLower() == "menu")
        {
          Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
          Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");
        }
        else if (line.ToLower() == "order") 
        {
          Console.WriteLine("Enter number of Bread:");
          string strBread = Console.ReadLine();
          int numBread;
          int numPasteries;
          if(int.TryParse(strBread, out numBread))
          {
            Console.WriteLine("Enter number of Pasteries:");
            string strPasteries = Console.ReadLine();
            if(int.TryParse(strPasteries, out numPasteries))
            {
              Bread bread = new Bread(numBread);
              Pastery  pastery = new Pastery(numPasteries);
              int orderCost = bread.getCost() + pastery.getCost();
              Console.WriteLine("You ordered {0} Bread", numBread);
              Console.WriteLine("You ordered {0} Pasteries", numPasteries);
              Console.WriteLine("Total Cost ${0} ", orderCost);
            }
            else
            {
              Console.WriteLine("There was an error in your input. Please try again.");
              Console.WriteLine(" Type Menu to bring up the menu, type order to place order or Type exit to exit the program");
            }
          }
          else
          {
            Console.WriteLine("There was an error in your input. Please try again.");
            Console.WriteLine(" Type Menu to bring up the menu, type order to place order or Type exit to exit the program");
          }
          

        }
        else
          {
            Console.WriteLine("There was an error in your input. Please try again.");
            Console.WriteLine(" Type Menu to bring up the menu, type order to place order or Type exit to exit the program");
          }
      }
    } 
  }
  
    
}


