using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NodeChain
{

    public class Node
    {
        public int Value
        {
            get;
            set;
        }

        public Node Next
        {
            get;
            set;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Node firts = new Node
            {
                Value = 5
            };

            Node middle = new Node
            {
                Value = 7
            };

            Node last = new Node
            {
                Value = 9
            };

            firts.Next = middle;
            middle.Next = last;

            PrintList(firts);
        }
    }

    private static void PrintList(Node node)
{
        while (node != null)
	{
	         Console.WriteLine(node.Value);
    node = node.Next;
	}

}


}
