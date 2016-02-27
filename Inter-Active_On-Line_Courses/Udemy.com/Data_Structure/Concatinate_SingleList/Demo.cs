using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleListConcatinate
{
    class Demo
    {
        static void Main(string[] args)
        {
            SingleLinkedList ListOne = new SingleLinkedList();
            SingleLinkedList ListTwo = new SingleLinkedList();

            Console.WriteLine("Please Enter the first list:");
            ListOne.CreateList();

            Console.WriteLine("Please Enter the second list: ");
            ListTwo.CreateList();

            Console.Write("First");
            ListOne.DisplayList();

            Console.WriteLine("Second");
            ListTwo.DisplayList();

            ListOne.Concatenate(ListTwo);
            Console.WriteLine("First");
            ListOne.DisplayList();

        }
    }
}
