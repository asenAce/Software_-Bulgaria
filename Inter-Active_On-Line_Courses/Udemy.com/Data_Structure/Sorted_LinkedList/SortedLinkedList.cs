using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLinkedList
{
    class SortedLinkedList
    {

        private Node start;

        public SortedLinkedList()
        {
            start = null;
        }




        internal void Create()
        {
            int i, n, data;

            Console.WriteLine("Please enter the numbers of Nodes: ");

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {              
                throw;
            }
             
                if (n == 0)
                {
                    return;
                } 

            for ( i = 0; i <= n; i++)
            {
                Console.WriteLine("Please write the element which will be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertInOrder(data);
            }
        }

        internal void InsertInOrder(int data)
        {
            Node temp = new Node(data);

            // List empty or new Node to be inserted before first Node
            if (start == null || data < start.info)
            {
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;

            while (p.link != null && p.link.info <= data)
            {
                p = p.link;
            }

            temp.link = p.link;
            p.link = temp;
        }

        internal void DisplayList()
        {
            Node p;

            if (start == null)
            {
                Console.WriteLine("The List is empty; ");
                return;
            }

            Console.WriteLine("List is: ");
            //the beginning of the list;
            p = start;

            while (p != null)
            {
                // list = [info][pointer] info = p.info where the value is tored , p.link is the pointer which is pointiong
                // to the next value in the list;
                // Displaying the value;
                Console.WriteLine(p.info + " ");
                // the pointer which point to the next info
                p = p.link;
            }

            Console.WriteLine();
        }

        

        internal void Search(int x)
        {
            if (start == null)
            {
                Console.WriteLine("The List is empty: ");
                return;
            }

            Node p = start;
            int position = 1;

            while (p != null && p.info <= x)
            {
                if (p.info == x)
                {
                    break;
                }

                position++;
                p = p.link;
            }

            if (p == null || p.info != x)
            {
                Console.WriteLine(x + "not found in the list");
            }

            else
            {
                Console.WriteLine(x + " is at position " + position);
            }
        }
    }
}
