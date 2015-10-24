using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" n =  ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(" min =  ");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine(" max =   ");
            int max = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < n;i++ )
            {
                /**
                 * Show on the console {0} place holder with possiton 0 , put data from variable with name random
                 * which is object./dot separator/ call method Next /which is onr of characteristics of the object /
                 * () is parameters in this case min,max ; end of the command
                 * */
                Console.WriteLine("{0}",random.Next(min,max)); 
            }
            Console.ReadLine();

        }
    }
}
