using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anArrya
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fruitBascet =
            {
                "Apple","\nOringe","\nPears","\nGrape","\nAvocado","\nFig","\nCoccos"
            };

            foreach (var product in fruitBascet)
            {
                Console.Write(product);
            }

            string [] names = new string [3];
            names[0] = "Joy";
            names[1] = "Marta";
            names[2] = "Barabarta";

            int[] weight = 
            { 
                   12, 34, 56, 12, 23 
            };
            int sum = weight.Sum();
            Console.WriteLine("The sum is :  " +sum);

            double average = weight.Average();
            Console.WriteLine(average);

            useArray(names);

            Console.ReadLine();
        }

        static void useArray(string[] values)
        {
            Console.WriteLine("Values in the method: ");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
