using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exForForeEach
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            for (int i = 1; i <= 5; i++)
            {
                list.Add(i);
            }

            foreach (int g in list)
            {
                if (g == 5)
                {

                    Console.Write(g);
                }
            }
        }
    }
}
