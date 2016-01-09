using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoopTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 }; // An array [] of numbers ,type, ID = assignment {};
            foreach(int i in numbers)
            {
                Console.Write(""+i);
            }
            Console.WriteLine();
            String[] towns = { " Sofia ", " Plovdiv " , " Varna " , " Bourgas "};
            foreach( String town in towns)
            {
                Console.Write("" + town);
            }
            Console.ReadLine();
        }
    }
}
