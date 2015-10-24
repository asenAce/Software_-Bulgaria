using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ThirdDigitIs
{

    //Write an expression that checks for given integer if its
    //third digit from right-to-left is 7.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Description of the program: Write an expression that checks for given integer if its third digit from right-to-left is 7.");
            Console.WriteLine("*****************************************");
            Console.WriteLine("State your number please: ");
            int number = int.Parse(Console.ReadLine());
            int leftNumber = number / 100;
            int theThirdDigit = leftNumber % 10; 

            bool isSeven = theThirdDigit == 7;
            Console.WriteLine("The Third digit of this number is:" + isSeven);
            Console.ReadLine();
        }
    }
}
