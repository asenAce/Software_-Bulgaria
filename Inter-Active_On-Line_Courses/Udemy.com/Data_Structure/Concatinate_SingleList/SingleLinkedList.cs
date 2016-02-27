using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleListConcatinate
{
    class SingleLinkedList
    {
        // initialize the list
        private Node start;

        public SingleLinkedList()
        {
            this.start = null;
        }


        public void Concatenate(SingleLinkedList list)
        {
            if (start == null)
            {
                start = list.start;
                return;
            }

            if (list.start == null)
            {
                return;
            }

            Node p = start;
            while (p.link != null)
            {
                p = p.link;
            }

            p.link = list.start;
        }


        internal void CreateList()
        {
            int i, n, data;

            Console.WriteLine("Please enter the numbers of Nodes: ");

            try
            {
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                {
                    return;
                }

                for (i = 1; i <= n; i++)
                {
                    try
                    {
                        Console.WriteLine("Please enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        InsertAtTheEnd(data);
                    }
                    catch (Exception anExpected)
                    {
                        Console.WriteLine(anExpected.Message);
                    }
                }
            }
            catch (Exception anExpected)
            {
                Console.WriteLine(anExpected.Message);
            }
        }

        private void InsertAtTheEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if (start == null)
            {
                start = temp;
                return;
            }

            p = start;

            while (p.link != null)
            {
                p = p.link;
            }

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
    }
}
