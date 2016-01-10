
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CurrencyCheck
{
    class CurrencyCheck
    {
        static void Main(string[] args)
        {

            decimal r = decimal.Parse(Console.ReadLine());
            decimal d = decimal.Parse(Console.ReadLine());
            decimal e = decimal.Parse(Console.ReadLine());
            decimal levaB = decimal.Parse(Console.ReadLine());
            decimal levaM = decimal.Parse(Console.ReadLine());

            r = r / 100 * 3.5M;
            d = d * 1.5M;
            e = e * 1.95M;

            levaB = levaB / 2M;

            decimal[] prices = new decimal[]    //creating a massive;
            {
                r,d,e,levaB,levaM
            };

            decimal minPrice = prices.Min();
            Console.WriteLine("{0:f2}",minPrice);



        }
    }
}
