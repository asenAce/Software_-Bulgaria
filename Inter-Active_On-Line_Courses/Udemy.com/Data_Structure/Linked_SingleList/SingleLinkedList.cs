using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkLists
{
  public  class SingleLinkedList
    {
        // initialize the list
        private Node start;

        public SingleLinkedList()
        {
            this.start = null;
        }

        public void DisplayTheList()
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

        public void CreateList()
        {
            int i, n, data;

            Console.WriteLine("Please enter the numbers of Nodes: ");

            try
            {
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 0 )
                {
                    return;
                }

                for ( i = 1; i <= n; i++)
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

        // Function CountNodes()
        public void CountNodes()
        {
            int n = 0;

            Node p = start;

            while (p != null)
            {
                n++;
                p = p.link;
            }

            Console.WriteLine("The Numbers of the nodes in the list = " + n);
        }

        // Function Search();  
        public bool Search(int data)
        {

            int position = 1;
            Node p = start;

            while (p != null)
            {
                // you found it
                if (p.info == data)
                {
                    break;
                }

                position++;
                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine("The program did not found the {0} in the list:",data);
                return false;
            }

            else
            {
                Console.WriteLine(data + " element {0} is at position >> ", position);
                return true;
            }

        }

        public void InsertInTheBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;

        }

        public void InsertAtTheEnd(int data)
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

        public void InsertAfter(int data, int elementX)
        {
            Node p = start;

            while (p != null)
            {
                if (p.info == elementX)
                {
                    break;
                }

                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine(elementX + "is not present in the list: ");
            }

            else
            {
                Node temp = new Node(data);

                temp.link = p.link;
                p.link = temp;

            }

        }

        public void InsertBefore(int data,int positionX)
        {
            Node temp;

            //If the list is empty
            if (start == null)
            {
                Console.WriteLine("The List is empty: ");
                return;
            }

            // x is in the first node,new node is to be inserted before first node: 

            if (positionX == start.info)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            //Find a reference to predecessor of the node containing x
            Node p = start;

            while (p != null)
            {
                if (p.link.info == positionX)
                {
                    break;
                }

                p = p.link;
            }

            if (p.link == null)
            {
                Console.WriteLine(positionX + "is not presont in the list.");
            }

            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertAtPossition(int data, int possitionX)
        {

            Node temp;
            int i;

            if (possitionX == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;

                return;
            }

            Node p = start;
            // find a reference to possitionX-1 NODE
            for ( i = 1; i < possitionX-1 && p != null; i++)
            {
                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine("you can insert only up to." + i + "the possition.");
            }

            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }

        }

        public void DeleteTheFirstNode()
        {
            //empty!
            if (start == null)
            {
                return;
            }

            start = start.link;
        }

        public void DeleteTheLastNode()
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

        public void DeleteNode(int data)
        {
            if (start == null)
            {
                Console.WriteLine("The List is empty");
                return; 
            }

            // Deletion of the first node;
            if (start.info == data)
            {
                start = start.link;
                return;
            }
            //Deletion in between or at the end;

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
                Console.WriteLine("Element " + data + "not in the list.");
            }

            else
            {
                p.link = p.link.link;
            }

        }

        public void ReverseList()
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

        public void BubbleSortExData()
        {

            Node end, p, q;

            for (end = null; end != start.link; end = p)
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

        public void BubbleSortExLinks()
        {

            Node end, r, p, q, temp;

            for (end = null; end != start.link; end = p )
            {
                for (r = p = start; p.link != end;r = p,p = p.link )
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

        public SingleLinkedList MergeOne(SingleLinkedList aList)
        {
            SingleLinkedList aMergeList = new SingleLinkedList();

            aMergeList.start = MergeOne(start,aList.start);
            return aMergeList;

        }

        private Node MergeOne(Node p1, Node p2)
        {

            Node startMerge;

            if (p1.info <= p2.info)
            {
                startMerge = new Node(p1.info);
                p1 = p1.link;
            }

            else
            {
                startMerge = new Node(p2.info);
                p2 = p2.link;
            }

            Node pM = startMerge;

            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pM.link = new Node(p1.info);
                    p1 = p1.link;
                }
                else
                {
                    pM.link = new Node(p2.info);
                    p2 = p2.link;
                }

                pM = pM.link;
            }
            // if second list has finished and elements left in the first list.
            while (p1 != null)
            {
                pM.link = new Node(p1.info);
                p1 = p1.link;
                pM = pM.link;
            }
            // if first list has finished and elements left in second list.
            while (p2 != null)
            {
                pM.link = new Node(p2.info);
                p2 = p2.link;
                pM = pM.link;
            }

            return startMerge;
        }

        public SingleLinkedList MergeTwo(SingleLinkedList aList)
        {

            SingleLinkedList mergeList = new SingleLinkedList();

            mergeList.start = MergeTwo(start,aList.start);
            return mergeList;
        }
        //                          start , node
        private Node MergeTwo(Node p1, Node p2)
        {
             // p1 = start p2 = node;
            Node startMerge;

            if (p1.info <= p2.info)
            {
                startMerge = p1;
                p1 = p1.link;
            }

            else
            {
                startMerge = p2;
                p2 = p2.link;
            }

            Node pM = startMerge;

            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pM.link = p1;
                    pM = pM.link;
                    p1 = p1.link;
                }
                else
                {
                    pM.link = p2;
                    pM = pM.link;
                    p2 = p2.link;
                }
            }

            if (p1 == null)
            {
                pM.link = p2;
            }

            else
            {
                pM.link = p1;
            }

            return startMerge;
        }

        public void MergeSort()
        {
            start = MergeSortRec(start);
        }

        private Node MergeSortRec(Node listStart)
        {
            // if the list is empty or has ..
            if (listStart == null || listStart.link == null)
            {
                return listStart;
            }

            // if more than one element
            Node startOne = listStart;
            Node startTwo = DivideTheList(listStart);

            startOne = MergeSortRec(startOne);
            startTwo = MergeSortRec(startTwo);

            Node startM = MergeTwo(startOne,startTwo);

            return startM;

        }

        // p = listStart;
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

        //Finding and Removing a cycle in a LinkedList
        public bool HasCycle()
        {
            if (FindCycle() == null)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        

        private void RemoveCycle()
        {

            Node c = FindCycle(); 

            if (c == null)
            {
                return;
            }

            Console.WriteLine("Node at witch the cycle was detected is " + c.info);


            Node p = c, q = c;
            int lenCycle = 0;

            do
            {
                lenCycle++;
                q = q.link;
            } while (p != q);
            Console.WriteLine("Length of cycle is: " + lenCycle);

            int lenRemList = 0;
            p = start;

            while (p != q)
            {
                lenRemList++;
                p = p.link;
                q = q.link;
            }

            Console.WriteLine("Number of nodes not included in the cycle are: "+ lenRemList);

            int lengthList = lenCycle + lenRemList;
            Console.WriteLine("Lenght of the list is: " + lengthList);

            p = start;
            for (int i = 0; i < lengthList -1; i++)
            {
                p = p.link;

            }
            p.link = null; 
        }

        private object FindCycle()
        {
            if (start == null || start.link == null)
            {
                return null;
            }

            else
            {
                return true;
            }

            Node slowR = start, fastR = start;

            while (fastR != null && fastR.link != null)
            {
                slowR = slowR.link;
                fastR = fastR.link.link;

                if (slowR == fastR)
                {
                    return slowR;
                }
            }

            return null;
        }

        public void InsertCycle(int x)
        {
            if (start == null)
            {
                return;
            }

            Node p = start, px = null, prev = null;

            while (p != null)
            {
                if (p.info == x)
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
                Console.WriteLine(x + "not present in the list.");
            }
        }

        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("The List is empty ");
                return;
            }

            p = start;
            Console.WriteLine("List is : ");

            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.next;
            }

            Console.WriteLine();
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.next = start;
            start.prev = temp;
            start = temp;

        }

        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            start = temp;
        }


        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);

            Node p;

            while (p.next != null)
            {
                p = p.next;
            }

            p.next = temp;
            temp.prev = p;
        }

        public void CreateList()
        {

            int i, n, data;
            Console.WriteLine("Enter the number of Nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                return;
            }

            Console.WriteLine("Enter the first element to be inserted: ");
            data = Convert.ToInt32(Console.ReadLine());
            InsertInEmptyList(data);

            for (  i = 2; i <=  n; i++)
            {
                Console.WriteLine("Enter the next element to be inserted : ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtTheEnd(data);
            }      
        }

        public void InsertAfter(int data,int x)
        {

            Node temp = new Node(data);

            Node p = start;

            while (p != null)
            {
                if (p.info ==x)
                {
                    break;
                }

                p = p.next;
            }

            if (p == null)
            {
                Console.WriteLine(x + "not present in the list."); 
            }

            else
            {
                temp.prev = p;
                temp.next = p.next;
            }
        }

       

    }
}
