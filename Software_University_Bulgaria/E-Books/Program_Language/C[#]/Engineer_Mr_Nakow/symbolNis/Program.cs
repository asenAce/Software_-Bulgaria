using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbolNis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;

            string sum = "Sum= " + (a + b);
            Console.WriteLine(sum);

            string incorrect = "Sum=" + a + b;
            Console.WriteLine(incorrect);

            Console.WriteLine("Perimeter = "  + 2 * (a + b ) + ".Area = " + (a * b ) + ".");
            Console.Read();

            int r = (150 - 20) / 2 + 5;
            // Expression for calculation of the surface of the circle
            double surface = Math.PI * r * r;

            //Expression for calculation of the perimeter of the circle
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine(r);
            Console.WriteLine(surface);
            Console.WriteLine(perimeter);

            int q = 5;
            int w = ++q;

            Console.WriteLine(q);
            Console.WriteLine(w);
            Console.Read();
            






        }



    }
}
