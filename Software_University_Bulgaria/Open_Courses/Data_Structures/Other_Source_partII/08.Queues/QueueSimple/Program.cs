using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSimple
{
    class Program
    {
        static void Main(string[] args)
        {
                // Declaring a Queue ID simple type<int>
            Queue<int> simple = new Queue<int>();
                // Storing values Enqueue is a method of the object simple () parameters passing value 10 into it;
            simple.Enqueue(10);
            simple.Enqueue(20);
            simple.Enqueue(30);
            simple.Enqueue(40);
            simple.Enqueue(50);

                      
                // Removing values 
            int one = simple.Dequeue();
            int two = simple.Dequeue();

            string theName = Console.ReadLine();

            Queue<string> secondSimple = new Queue<string>();

            secondSimple.Enqueue(theName);
            secondSimple.Enqueue("Asen");
            secondSimple.Enqueue("pETROW");
            secondSimple.Enqueue("Bow");
            secondSimple.Enqueue("Wow");
            secondSimple.Enqueue("Plow");
            secondSimple.Enqueue("Pool");

            string oneOne = secondSimple.Dequeue();
            string twoTwo = secondSimple.Dequeue();

            


            foreach (var item in secondSimple)
            {
                if (item == "")
                {
                    Console.WriteLine("empty");
                }

                else
                {
                    Console.WriteLine(item);
                }
            }




        }
    }
}
