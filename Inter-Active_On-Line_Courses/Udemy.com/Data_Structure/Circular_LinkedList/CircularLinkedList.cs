using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  

namespace CircularLinkedList
{
    class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
        }

        public void CreateList()
        {
            int i, n, data;

            Console.WriteLine("Please entered the numbers of Nodes to inserted: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                return;
            }

            Console.WriteLine("Please enter the numbers of the Nodes: ");
            try
            {
                data = Convert.ToInt32(Console.ReadLine());
                InsertInEmptyList(data);
            }
            catch (Exception anExpected)
            {
                Console.WriteLine(anExpected.Message);
            }

            if (n == 0)
            {
                return;
            }

            Console.WriteLine("Please enter the element to be inserted: ");
            try
            {
                data = Convert.ToInt32(Console.ReadLine());
                InsertInEmptyList(data);
            }
            catch (Exception anExpected)
            {
                Console.WriteLine(anExpected.Message);
            }

            for ( i = 2; i <= n; i++)
            {
                try
                {
                    Console.WriteLine("Please enter the element to be inserted: ");
                    data = Convert.ToInt32(Console.ReadLine());
                    InsertAtEnd(data);
                }
                catch (Exception anExpected)
                {
                    Console.WriteLine(anExpected.Message);
                }
            }
        }

        public void DisplayList()
        {

            if (last == null)
            {
                Console.WriteLine("List is empty \n");
                return;
            }

            Node p = last.link;

            do
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            } while (p != last.link);
            Console.WriteLine();
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);

            temp.link = last.link;
            last.link = temp;
        }

        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);

            last = temp;
            last.link = last;
        }

        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);

            temp.link = last.link;
            last.link = temp;
            last = temp;
        }

        public void InsertAfter(int data,int x)
        {
            Node p = last.link;

            do
            {
                if (p.info == x)
                {
                    break;
                }

                p = p.link;
            } while (p != last.link);

            if (p == last.link && p.info != x)
            {
                Console.WriteLine(x + " not present in the list<> ");
            }

            else
            {
                Node temp = new Node(data);

                temp.link = p.link;
                p.link = temp;

                if (p == last)
                {
                    last = temp;
                }
            }
        }
         
        internal void DeleteFirstNode()
        {
            // the list is empty
            if (last == null)
            {
                return;
            }

            // the list has only one Node.
            if (last.link == last)
            {
                last = null;
                return;
            }

            last.link = last.link.link;
        }

        internal void DeleteLastNode()
        {
            // List is empty
            if (last == null)
            {
                return;
            }
            // The List has only one Node
            if (last.link == last)
            {
                last = null;
                return;
            }

            Node p = last.link;
            while (p.link != last)
            {
                p = p.link;
            }

            p.link = last.link;
            last =p;
        }

        internal void DeleteNode(int x)
        {
            // List is empty
            if (last == null)
            {
                return;
            }

            //Deletion of only one Note
            if (last.link == last && last.info == x)
            {
                last = null;
                return;
            }

            //Deletion of the first node.
            if (last.link.info == x)
            {
                last.link = last.link.link;
                return;
            }

            Node p = last.link;

            while (p.link != last.link)
            {
                if (p.link.info == x)
                {
                    break;
                }

                p = p.link;
            }

            if (p.link == last.link)
            {
                Console.WriteLine(x + "not found in the list.");
            }

            else
            {
                p.link = p.link.link;

                if (last.info == x)
                {
                    last = p;
                }
            }
        }

        public void Concatenate(CircularLinkedList list)
        {
            if (last == null)
            {
                last = list.last;
                return;
            }

            if (list.last == null)
            {
                return;
            }

            Node p = last.link;
            last.link = list.last.link;
            list.last.link = p;
            last = list.last;

        }
    }
}
