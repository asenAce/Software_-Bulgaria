
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReversedList
{

    /**
     * ⦁	Implement the Data Structure ReversedList<T>
     * 
Implement a data structure ReversedList<T> that holds a sequence of elements of generic type T. It should hold a sequence of items in reversed order. The structure should have some capacity that grows twice when it is filled. The reversed list should support the following operations:
⦁	Add(T item)  adds an element to the sequence (grow twice the underlying array to extend its capacity in case the capacity is full)
⦁	Count  returns the number of elements in the structure
⦁	Capacity  returns the capacity of the underlying array holding the elements of the structure
⦁	this[index]  the indexer should access the elements by index (in range 0 … Count-1) in the reverse order of adding
⦁	Remove(index)  removes an element by index (in range 0 … Count-1) in the reverse order of adding
⦁	IEnumerable<T>  implement an enumerator to allow iterating over the elements in a foreach loop in a reversed order of their addition
Hint: you can keep the elements in the order of their adding, by access them in reversed order (from end to start).

     * 
     * */

    class ReversedListTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
          //creates GenericList<int>
            ReversedList<int> list = new ReversedList<int>();

            //empty list test
            Console.WriteLine (list);

            //adding test
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
                Console.WriteLine(list);
            }

            // ToString()
            Console.WriteLine(list);

            //removing element by index test
            for (int i = 9; i >= 0; i--)
            {
                list.Remove(i);
                Console.WriteLine(list);
            }

            list.Add(6);
            list.Add(1);
            list.Add(7);
            list.Add(5);
            list.Add(9);
            list.Add(2);
            list.Add(8);
            list.Add(0);
            list.Add(3);
            list.Add(4);

            // ToString()
            Console.WriteLine(list);

            //foreeach
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //count
            Console.WriteLine("Count: {0}",list.Count);

            //Capacity
            Console.WriteLine("Capacity: {0}",list.Capacity);

        }
    }
}
