using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ?");
            int n = int.Parse(Console.ReadLine());
            int [] array = { 1,2,3,4 };

            for (int i = 0; i < n; i++ )
            {
                array [i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
