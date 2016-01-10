using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SpyHard
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeralSystem = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int totalValue = 0;
            string convertedValue = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]>= 'A' && input[i]<='Z' )
                {
                    totalValue = totalValue + input[i] - 64;
                }
                else if (input[i]>= 'a' && input[i]<= 'z')
                {
                    totalValue = totalValue + input[i] - 96;
                }
                else
                {
                    totalValue = totalValue + (int)input[i];
                }
            }

            do
            {
                convertedValue = convertedValue + (totalValue % numeralSystem);
                totalValue = totalValue / numeralSystem;
            } while (totalValue != 0);
            Console.Write(numeralSystem.ToString()+
                input.Length);
                convertedValue.ToCharArray().Reverse().ToList().ForEach(c=> Console.Write(c));
            Console.ReadLine();
        }
    }
}
