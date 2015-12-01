using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class Start
    {
        static void Main(string[] args)
        {
            bool itIsTrue = true;
           
            Console.WriteLine("Please write a number: ");

            while (itIsTrue)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    Square aSquare = new Square(num);

                    if (num < 0)
                    {
                        throw new ArgumentOutOfRangeException("Incorrect");
                    }

                    aSquare.CalculateTheSquare(num);
                    Console.WriteLine(aSquare);

                }
                catch (Exception)
                {

                    throw new ArgumentException("Incorect");
                }

                finally
                {
                    Console.WriteLine("Thank you");
                }



            }

        }
    }
}
