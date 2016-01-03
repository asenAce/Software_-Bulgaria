using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Lesson.LinkedList
{
    // A linked list collection capable of basic operations such as 
    // Add, Remove , Finf and Enumerate

    public class LinkedList<T> :
        System.Collections.Generic.ICollection<T>
    {
        // The first node in the list or null if empty

        public LinkedListNode<T> Head
        {
            get;
            private set;
        }

        // The last node in the list or null if empty

        public LinkedListNode<T> Tail
        {
            get;
            private set;
        }

        #region Add
        //Add the specified value to the start of the linked list
        //The value to add to the start of the list.

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }
        //Adds the specified node to the start of the list.
        public void AddFirst(LinkedListNode<T> node)
        {
            //Save off the head node so we do not lose it.
            LinkedListNode<T> temp = Head;

            //Point head to the new node
            Head = node;

            //Insert the rest of the list behind the head
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                // if the list was empty then Head and tail should , both point to the new node.
                Tail = Head;
            }

        }

        // Add value to the end of the list.
        //The value to add!

        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        //Add note to the end of the the list
        //The node to add.

        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }

            else
            {
                Tail.Next = node;
            }

            Tail = node;
            Count++;
        }

        #endregion

        #region Remove

        //Removes the first node from the list.

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                // Before: Head --> 3 -> 5
                // After: Head  -----> 5
                // Head -- >3 --> null
                // Head -----> null

                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        // Removes the last node from the last 

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count != 1 )
                {
                    Head = null;
                    Tail = null;
                }
                
                else
                {
                    // Before: Head --> 3 -- > 5 --> 7
                    // Tail = 7
                    // After: Head --> 3 --> 5 --> null
                    // tail = 5

                    LinkedListNode<T> current = Head;

                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }

                Count--;

            }
        }

        #endregion

        #region ICollection

        // The number of items currently in the list

        public int Count
        {
            get;
            private set;
        }

        //Adds the specified value to the front of the list
        //The Value to add.

        public void Add(T item)
        {
            AddFirst(item);
        }

        //Return true if the list contains the specifified item,
        //false otherwise
        //The item to search for
        //True if the item is found,false otherwise.

        public bool Contains(T item)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        /**
         * Copies the node values into the specified array.
         * The array to copy the linked list values to 
         * The index to the array to start copying at.
         * */

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        // True if the collection is read only, fakse otherwise.

        public bool IsReadOnly
        {
            get
            {
                return false;
            }

        }

        // Removes the first occurance of the item from the list(Searching from Head to Tail.)
        // from Head to Tail.
        // The item to remove 
        // True if the item was found and removed , false otherwise.
 
        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;

            /**
             * 1: Empty list - do nothing.
             * 2: Single node:(previous is null)
             * 3: Many nodes.
             *      a: node to remove is the first node.
             *      b: node to remove is the middle node or last.
             * 
             * */

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
            // It is  a node in the middle or end.
                    if (previous != null)
                    {
            // case 3b 
            // Before : Head --> 3 ----> 5 --. null
            // After : Head --> 3 ---> null
                        previous.Next = current.Next;
            // it was the end - so update Tail.
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }

                        Count--;
                    }
                    else
                    {
            // Case 2 or 3a
                        RemoveFirst();
                    }
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        //Enumerates over the linked list values from Head to Tail.
        //A Head to Tail enumerator.

        System.Collections.Generic.IEnumerator<T>System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        //Enumerates over the linked list values from Head to Tail.
        //A Head to Tail enumerator.

        System.Collections.Generic.IEnumerator<T>System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            return
                ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();

        }

        //Removes all the nodes from the list 

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        #endregion

    }
}
