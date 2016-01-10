using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CurrentCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // take the value from the user
            decimal r = decimal.Parse(Console.ReadLine());
            decimal d = decimal.Parse(Console.ReadLine());
            decimal e = decimal.Parse(Console.ReadLine());
            decimal levaB = decimal.Parse(Console.ReadLine());
            decimal levaM = decimal.Parse(Console.ReadLine());
            // Those are the current courses calculated 
             r = r / 100 * 3.05M;
             d = d * 1.5M;
             e = e * 1.95M;
             levaB = levaB / 2M;
            // array
             decimal[] prices = new decimal[]
            {
                r,d,e,levaB,levaM
            };
            // Instantiate a variable minPrice of decimal type = asign value object price which is
            // an Array with all the values in it . method Min calculate the min value 
             decimal minPrice = prices.Min();
             Console.WriteLine("{0:f2}",minPrice);
             Console.ReadLine();



        }
    }
}
