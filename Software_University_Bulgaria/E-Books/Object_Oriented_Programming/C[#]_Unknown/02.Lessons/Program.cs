using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CalculationRate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  const double TAX_RATE = 0.06;   
             *  string itemPriceAsString;    
             *  double itemPrice;    
             *  double total;     
             *  Console.Write("Enter the price of an item >> ");    
             *  itemPriceAsString = Console.ReadLine();    
             *  itemPrice = Convert.ToDouble(itemPriceAsString);    
             *  total = itemPrice * TAX_RATE;     
             *  Console.WriteLine("With a tax rate of {0}, a {1} item " +       
             *  "costs {2} more.", TAX_RATE, itemPrice.ToString("C"),   total.ToString("C"));

             * 
             * */


            const double DDS_RATE = 0.22;   // constantna
            string itemPriceAsString;       // Declaring variables 
            double itemPrice;       // using two variables in oreder to convert on of them like the example with the glasses and oringe juse.
            double total;

            Console.WriteLine("Enter the price of an item >> ");
            itemPriceAsString = Console.ReadLine();
            itemPrice = Convert.ToDouble(itemPriceAsString);   // passing paramethers.
            total = itemPrice * DDS_RATE; // The formula
            Console.WriteLine("With a tax rate of {0}, a {1} item " + "cost {2} more.",DDS_RATE,itemPrice.ToString("C"),total.ToString("C"));

            // itemPrice = Convert.ToDouble(Console.ReadLine())
            // itemPrice = Convert.ToDouble(Console.ReadLine());
            
            Console.Read();

        }
    }
}
