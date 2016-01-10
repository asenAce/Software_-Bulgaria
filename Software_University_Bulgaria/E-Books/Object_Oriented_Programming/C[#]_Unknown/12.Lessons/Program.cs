using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] validValues = { 220,334,555,667,778,434,4343,4343,55,};
            double[] prices = { 454,55,667,1.23,44,};
            int itemOrdered;
            double itemPrice = 0;
            bool isValidItem = false;
            Console.WriteLine("Please enter an item");
            itemOrdered = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < validValues.Length; x++)
            {
                if (itemOrdered == validValues[x])
                {
                    isValidItem = true;
                    itemPrice = prices[x];
                }
            }

            if (isValidItem)
            {
                Console.WriteLine("Price is {0}", itemPrice);
            }
            else
            {
                Console.WriteLine("Sorry - item not found");
            }
        }
    }
}
