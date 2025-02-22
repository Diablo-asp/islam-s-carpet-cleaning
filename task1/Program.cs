using Microsoft.VisualBasic;
using System.Linq.Expressions;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // charges
               int small = 25;
               int large = 35;
               double tax = 6.6;

            // list
                  Console.WriteLine("Price per smaal Room = 25$");
                  Console.WriteLine("Price per large Room = 35$");
                  Console.WriteLine("Tax = 6.6$");
                  Console.WriteLine("the estimate is valid for 30 day's");

            // carpet Quantity
                  Console.WriteLine("How Many Small Carpet you need to clean?");
               int smallOne = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("How Many large Carpet you need to clean?");
               int largeOne = Convert.ToInt32(Console.ReadLine());

            // cost
               int cost = (small * smallOne) + (large * largeOne);
                  Console.WriteLine("Total cost = " + cost + "$");

            // Tax
                  Console.WriteLine("+Tax =" + (tax));
                  Console.WriteLine("total estimated = " + (cost + tax) + "$");

        }
    }
}
