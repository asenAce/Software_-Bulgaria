using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int number = int.Parse(str);
            Console.WriteLine("You entered:  {0}",number);
            Console.Read();
        }
    }
}
