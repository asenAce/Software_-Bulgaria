using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterANumber
{
    class Start
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int maxArrayElement = numbers.Max();
                int min = Math.Max(2,maxArrayElement + 1);
                int max = 100 - 10 + i;

                Console.WriteLine("Please enter a number:");
                numbers[i] = ReadNumber(min,max);

            }

            Console.WriteLine("\nYou entered the following 10 numbers: ");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number {0} : {1}",i + 1, numbers[i]);
            }

        }

        private static int ReadNumber(int min, int max)
        {
            string input = Console.ReadLine();

            try
            {
                int num = int.Parse(input);

                if (num < min || num > max)
                {
                    throw new ArgumentOutOfRangeException("input",String.Format("Number should be between {0} and {1}.",min,max));
                }

                return num;
            }
            catch (Exception)
            {

                Console.WriteLine(String.Format("Number should be in the range [{0}....{1}].Try again"),min,max);
                return ReadNumber(min,max);
            }
            
            
        }
    }
}
