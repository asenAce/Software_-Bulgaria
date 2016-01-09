using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int num = 50;
            int sum = 50;
            Console.Write("The sum 1");
            while ( num <n)
            {
                num++;
                sum = sum + num;
                Console.Write("+" + num);
            }
            Console.WriteLine(" = "+ sum);
            Console.Read();
        }
    }
}
