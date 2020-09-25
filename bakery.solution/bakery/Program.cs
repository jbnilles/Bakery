using System;
using Bakery.Models;


namespace Bakery
{
  public class Program
  {
     public static void Main() 
    {
      string line = "";
      Console.WriteLine("Welcome to Pierre's Bakery! Type Menu to bring up the menu, type order to place order or Type exit to exit the program")
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
          if(int.TryParse(strBread, numBread))
          {
            Console.WriteLine("Enter number of Pasteries:");
            string strPasteries = Console.ReadLine();
            if(int.TryParse(strPasteries, numPasteries))
            {

            }
          }
          else{

          }
          

        }
      }
    } 
  }
  
    
}


