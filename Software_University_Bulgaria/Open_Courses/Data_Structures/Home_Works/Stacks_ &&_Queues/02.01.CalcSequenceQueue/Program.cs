using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01.CalcSequenceQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            #region The Input
            Console.WriteLine("Please , input  N:");
            int firstNumber = int.Parse(Console.ReadLine());
            // Craetin an queue with parameters (new int[] { firstNumber }
            Queue<int> queue = new Queue<int>(new int[] { firstNumber });

            int sequenceLenght = 50;

            #endregion The Input

            #region The Logic
            while (sequenceLenght > 0)
            {
                int currentElement = queue.Dequeue();

                queue.Enqueue(currentElement + 1);
                queue.Enqueue(2 * currentElement + 1);
                queue.Enqueue(currentElement + 2);

                Console.WriteLine(currentElement + " ");

                
            }
            #endregion The Logic
        }
    }
}
