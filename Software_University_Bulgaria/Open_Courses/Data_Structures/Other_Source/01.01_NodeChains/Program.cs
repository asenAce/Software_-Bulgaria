using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._01_NodeChains
{   //First step.  creating Node
    public class Node
    {       // set and get a Value
        public int Value 
        {
            get;
            set;
        }

        public Node Next  // this is a pointer
        {
            get;
            set;
        }
    }

   
    

        

    class Program
    {
        static void Main(string[] args)
        {
            /** step1
             * +---------+-----------+
             * |  3      |   Null    +
             * |         |           +      
             * +---------+-----------+
             */
            Node first = new Node
            {
                Value=3
            };

            /** step2  Null pointer
             * +---------+-----------+  +------+------+
             * +   3     +   Null    +  +   5  + Null +
             * +---------+-----------+  +------+------+
             */

            Node middle = new Node
            {
                Value = 5
            };

            /** step3
             * +---------+-----------+   +------+------+
             * +   3     +   *-------+-->+   5  + Null +
             * +---------+-----------+   +------+------+
             */
            first.Next = middle;

            /** step4
             * +---------+-----------+   +------+------+  +-------+------+      
             * +   3     +   *-------+-->+   5  + Null +  +   7   + null +
             * +---------+-----------+   +------+------+  +-------+------+
             */

            Node last = new Node
            {
                Value = 7
            };

            /** step5
             * +---------+-----------+   +------+------+   +-------+------+      
             * +   3     +   *-------+-->+   5  + *----+-->+   7   + null +
             * +---------+-----------+   +------+------+   +-------+------+
             */
            middle.Next = last;

            // now iterate over each node and print the value, every one function is called from the main()
            PrintList(first);
        }

        //Creating the Function with ID PrintList.

        private static void PrintList(Node node) //passing a paramethers
        {
            while (node!=null)
	       {
	            Console.WriteLine(node.Value);
                node = node.Next;
           }
        }
      
      
    }
}
