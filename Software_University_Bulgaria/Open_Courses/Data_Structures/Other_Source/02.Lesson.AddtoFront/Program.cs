using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Lesson.AddtoFront
{
    class Program
    {
        public void AddFirst(LinkedListNode<T> node)
        {
            //Save off the head node so we do not lose it
            LinkedListNode<T> temp = Head;

            //Point head to the new node
            Head = node;

            //Insert the rest of the list behind the head
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                // if the list was empty then Head and Tail should 
                // both point to the new node.
                Tail = Head;
            }

        }


        static void Main(string[] args)
        {



        }
    }
}
