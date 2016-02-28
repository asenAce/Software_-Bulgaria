using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeData
{
    public  class SingleLinkedList
    {

        private Node start;

        public SingleLinkedList()
        {
            this.start = null;
        }


        internal void Create()
        {
            // int i = information n = # of the Nodes.
            int i, n, data;
            Console.WriteLine();
            Console.WriteLine("How many Nodes will have the list? ");

            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                return;
            }

            for ( i = 1; i <= n ; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Please write down the value to be inserted:");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtTheEnd(data);
            }
        }

        internal void Count()
        {
            int n = 0;

            Node p = start;

            while (p != null)
            {
                n++;
                p = p.link;
            }

            Console.WriteLine("The Numbers of the Nodes in the List are = " + n);
        }

        internal void Display()
        {
            Node p;

            if (start == null)
            {
                Console.WriteLine("The List is empty:  ");
                return;
            }

            Console.WriteLine("The List is >>");
            p = start;

            while (p != null)
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
                Console.WriteLine("Command Display()  ");
            }

            Console.WriteLine();
        }

        internal void RemoveCycle()
        {
            // TO DO >>>


        }

        internal object DetectCycle()
        {
            Node slowR = start, fastR = start;

            while (fastR != null && fastR.link != null)
            {
                slowR = slowR.link;
                fastR = fastR.link.link;

                if (slowR == fastR)
                {
                    return slowR;
                }

                return null;
            }


            if (start == null || start.link == null)
            {
                return null;
            }

            else
            {
                return true;
            }   

            
        }

        internal void InsertCycle(int data)
        {
            if (start == null)
            {
                return;
            }

            Node p = start, px = null, prev = null;

            while (p != null)
            {
                if (p.info == data)
                {
                    prev = p;
                    p = p.link;
                }
            }

            if (px != null)
            {
                prev.link = px;
            }

            else
            {
                Console.WriteLine( data + "not present in the list. ");
            }
                 
        }
        // Errors !!
        public void MergeSort()
        {
            start = MergeSortRec(start);
        }

        private Node MergeSortRec(Node listStart)
        {
            //if the list is empty or has...
            if (listStart == null || listStart.link == null)
            {
                return listStart;
            }

            //if more than one element;
            Node startOne = listStart;
            Node startTwo = DivideTheList(listStart);

            startOne = MergeSortRec(startOne);
            startTwo = MergeSortRec(startTwo);

            Node startM = MergeTwo(startOne,startTwo);

            return startM;
        }

        // pOne =startOne ; pTwo = startTwo;
        private Node MergeTwo(Node pOne, Node pTwo)
        {
            
            // pOne = start ; pTwo = node;
            Node startMerge;

            if (pOne.info <= pTwo.info)
            {
                startMerge = pOne;
                pOne = pOne.link;
            }

            else
            {
                startMerge = pTwo;
                pTwo = pTwo.link;

            }

            Node pM = startMerge;

            while (pOne != null && pTwo != null)
            {
                if (pOne.info <= pTwo.info)
                {
                    pM.link = pOne;
                    pM = pM.link;
                    pOne = pOne.link;
                }

                else
                {
                    pM.link = pTwo;
                    pM = pM.link;
                    pTwo = pTwo.link;
                }
            }

            if (pTwo == null)
            {
                pM.link = pTwo;
            }

            else
            {
                pM.link = pOne;
            }

            return startMerge;

        }

        //p = listStart;
        private Node DivideTheList(Node p)
        {
            Node q = p.link.link;

            while (q != null && q.link != null)
            {
                p = p.link;
                q = q.link.link;
            }

            Node startTwo = p.link;
            p.link = null;

            return startTwo;

        }

        internal void BubbleSortByExchengingLinks()
        {
            Node end, r, p, q, temp;
            p = null;

            for (end = null; end != start.link;end = p ) 
            {
                for (r = p = start; p.link != end; r = p,p = p.link )
                {
                    q = p.link;

                    if (p.info > q.info)
                    {
                        p.link = q.link;
                        q.link = p;

                        if (p != start)
                        {
                            r.link = q;
                        }

                        else
                        {
                            start = q;
                        }

                        temp = p;
                        p = q;
                        q = temp;

                    }
                }
            }
        }

        internal void BubbleSortByExchengingData()
        {
            //?
            Node end, p, q;
            p = null;

            for (end = null; end != start.link; end = p )
            {
                for (p = start; p.link != end; p = p.link )
                {
                    q = p.link;

                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;

                    }
                }
            }

        }

        internal void Reverse()
        {
            Node prev, p, next;

            prev = null;
            p = start;

            while (p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }

            start = prev;
        }

        internal void DeleteAnyNode(int data)
        {
            if (start == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            if (start.info == data)
            {
                start = start.link;
                return;
            }

            Node p = start;

            while (p.link != null)
            {
                if (p.link.info == data)
                {
                    break;                    
                }

                p = p.link;
            }

            if (p.link == null)
            {
                Console.WriteLine("Element not found " + data + "not in the list.");
            }

            else
            {
                p.link = p.link.link;
            }
        }

        internal void DeleteLastNode()
        {
            if (start == null)
            {
                return;
            }

            if (start.link == null)
            {
                start = null;
                return;
            }

            Node p = start;

            while (p.link.link != null)
            {
                p = p.link;
                p.link = null;
            }
        }

        internal void DeleteFirstNode()
        {
            if (start == null)
            {
                return;
            }

            start = start.link;
        }

        internal void InsertAtSpecifiedPosition(int data, int x)
        {
            Node temp;

            int i;

            if (x == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;

                return;

            }

            Node p = start;

            for ( i = 1; i < x - 1 &&  p != null; i++)
            {
                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine("you can insert only up to ." + i + "position.");
            }

            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }

        }

        internal void InsertAtSpecifiedBeforeNode(int data, int x)
        {
            Node temp;

            if (start == null)
            {
                Console.WriteLine("The List is empty: ");
                return;
            }

            if (x == start.info)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;

            while (p != null)
            {
                if (p.link.info == x)
                {
                    break;
                }

                p = p.link;
            }

            if (p.link == null)
            {
                Console.WriteLine( x + " is not presont in the list.");
            }

            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }


        }

        internal void InsertAtSpecifiedAfterNode(int data, int x)
        {
            Node p = start;

            while (p != null)
            {
                if (p.info == x)
                {
                    break;
                }

                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine( x + " is not in the List :");
            }


            else
            {
                Node temp = new Node(data);

                temp.link = p.link;

            }
        }

        internal void InsertAtTheEnd(int data)
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

        internal void InsertAtTheBeginning(int data)
        {
            Node temp = new Node(data);

            temp.link = start;
            start = temp;

        }

        public bool Search(int data)
        {
            int position = 1;
            Node p = start;

            while (p != null)
            {
                // 
                if (p.info == data)
                {
                    break;
                }

                position++;
                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine("The program did not found it {0} in the list.",data);
                return false;
            }

            else
            {
                Console.WriteLine(data + " element {0} is at position >> ",position);
                return true;
            }

        }



        public SingleLinkedList MergeOne(SingleLinkedList list)
        {

            SingleLinkedList aMergeList = new SingleLinkedList();

            aMergeList.start = MergeOne(start,list.start);

            return aMergeList;

        }
        // Error !
        private Node MergeOne(Node pOne, Node pTwo)
        {

            Node startMerge;

            if (pOne.info <= pTwo.info)
            {
                startMerge = new Node(pOne.info);
                pOne = pOne.link;
            }

            else
            {
                startMerge = new Node(pTwo.info);
                pTwo = pTwo.link;
            }

            Node pM = startMerge;

            while (pOne != null && pTwo != null)
            {
                if (pOne.info <= pTwo.info)
                {
                    pM.link = new Node(pOne.info);
                    pOne = pOne.link;
                }

                else
                {
                    pM.link = new Node(pTwo.info);
                    pTwo = pTwo.link;
                }

                pM = pM.link;

                // if the Second list has finished and element left in the first list.
                while (pOne != null)
                {
                    pM.link = new Node(pOne.info);
                    pOne = pOne.link;
                    pM = pM.link;
                }

                //If first list has finished and elements left in second list.
                while (pTwo != null)
                {
                    pM.link = new Node(pTwo.info);
                    pTwo = pTwo.link;
                    pM = pM.link;
                }

                return startMerge;

            }

        }
    }
}
