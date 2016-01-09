using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates " + "the area of a rectangle or a triangle");

            Console.WriteLine("Enter a and b (for rectangle) " + "or a and h (for triangle): ");

            int a = int.Parse(Console.ReadLine());  // empty method ()
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1 for a rectangle or " +  "2 for a triangle: ");

            int choice = int.Parse(Console.ReadLine());
            double area = (double)(a * b) / choice;
            Console.WriteLine("The are of your figure is " + area);
            Console.ReadLine();

        }
    }
}
