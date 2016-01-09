using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> simpleOne = new Queue<int>();

            for (int possitionOne = 0; possitionOne < 50; possitionOne++)
            {
                // 1 the Queue ID simpleOne . Method Enqueue add to the queue () parameters () passing possitionOne..
                simpleOne.Enqueue(possitionOne);
            }

            while (simpleOne.Count > 0 )
            {
                Console.WriteLine(simpleOne.Dequeue());
            }

        }
    }
}
