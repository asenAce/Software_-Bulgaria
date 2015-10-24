using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigitNumber
{
    class Program
    {
        //Write a program that takes as input a four-digit 
        //number in format abcd (e.g. 2011) and performs the following:

        static void Main(string[] args)
        {
            Console.WriteLine("This program do: Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:");
            Console.WriteLine("***************************************************");
            Console.WriteLine("Please state your number:");
            int number = int.Parse(Console.ReadLine());

            //Fourth digit
            int firstDigit = number % 10;
            //Console.WriteLine(firstDigit);
            /**
            Console.WriteLine("Which digit position do you need?");
            int digitPosition = int.Parse(Console.ReadLine());
            int secondDigit = (number / (int)Math.Pow(10, digitPosition - 1)) % 10;
            Console.WriteLine(secondDigit);
             * */
            //Third digit
            int restNumberTwo = number / 10;
            int secondDigit = restNumberTwo % 10;
            

            //second digit
            int restNumberThree = number / 100;
            int thirdDigit = restNumberThree % 10;

            //first digit
            int restNumberFour = number / 1000;
            int fourthDigit = restNumberFour % 10;

            Console.WriteLine("Number" + number);
            Console.WriteLine("Sum of digits" +(firstDigit+ secondDigit + thirdDigit + fourthDigit) );
            Console.WriteLine("Reverst{0}{1}{2}{3}",firstDigit,secondDigit,thirdDigit,fourthDigit);
            Console.WriteLine("Last digit in front {0}{1}{2}{3} ",firstDigit,secondDigit,thirdDigit,fourthDigit);
            Console.WriteLine(" second and third exchanged{0}{1}{2}{3}  ",firstDigit,secondDigit,thirdDigit,fourthDigit );
            Console.Read();

        }
    }
}
