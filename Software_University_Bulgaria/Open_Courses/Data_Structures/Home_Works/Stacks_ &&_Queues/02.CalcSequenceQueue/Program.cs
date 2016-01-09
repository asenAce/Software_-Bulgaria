using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CalcSequenceQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Input

            int start = int.Parse(Console.ReadLine());

            // Creating the Queue <int> type. with ID qResult. var is variable.
            var qResult = new Queue<int>();

            /** This is how you assigne the data from the Console to the Gueue<>
            * qResult is an Object .Enqueue is a method of the object. which add a data to the queue.() is parameters
             * in this case i am passing the parameter start in it () which mean take the data from the variable start and put 
             * it in the queue with name /ID/ qResult , the start take the value from the .Console
            */
            qResult.Enqueue(start);
            // initialiaze a new variable n of type int given = value 0;
            int n = 0;

            #endregion Input

            #region The Logic

            while (n <= 50)
            {   // Formulas that molds the sequences.
                qResult.Enqueue(start + 1);
                qResult.Enqueue((start * 2) + 1);
                qResult.Enqueue(start + 2);

                // Masive , check the method ToArray
                int[] nextStart = qResult.ToArray();
                start = nextStart[n + 1];
                n++;

            }
                // For loop
            for (int possition = 0; possition < qResult.Count; possition++)
            {
                Console.WriteLine(qResult.Dequeue() + ", ");
            }

            Console.WriteLine();
            #endregion The Logic

            #region The Output
            #endregion The Output

        }
    }
}
