using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellerBov
{
    class Program
    {
        static void Main(string[] args)
        {

            string leap = Console.ReadLine();
            int contracts = int.Parse(Console.ReadLine());
            int family = int.Parse(Console.ReadLine());

            double numberOfTtavels = contracts * 12;
            numberOfTtavels = numberOfTtavels + family * 4;
            numberOfTtavels = numberOfTtavels + (12 - contracts - family) * 12.0 * 3 / 5;

            if (leap == "leap")
            {
                numberOfTtavels = numberOfTtavels + numberOfTtavels * 5 / 100;
            }

            Console.WriteLine(Math.Floor(numberOfTtavels));
            Console.ReadLine();





        }
    }
}
