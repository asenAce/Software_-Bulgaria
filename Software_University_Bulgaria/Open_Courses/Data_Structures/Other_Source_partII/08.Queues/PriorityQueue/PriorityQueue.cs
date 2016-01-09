
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{      
        /**
        *A collection that returns the Highest priority item first and lowest priority item last.
        *The type of data stored in the collection.
        * */

    public class PriorityQueue<T> : System.Collections.Generic.IEnumerable<T>
        where T : IComparable<T>
    {
        System.Collections.Generic.LinkedList<T> items = new System.Collections.Generic.LinkedList<T>();

        #region Enqueue Function

        //Adds an item to the queue in priority order.
        //The item to place in the queue.

        public void Enqueue(T item)
        {
            //if the list is empty ,just add the item.
            if (items.Count == 0)
            {
                items.AddLast(item);
            }

            else
            {
                //find the proper insert point.
                var current = items.First;

                /**
                 * While we are not at the end of the list and the current value is larger than the value being inserted...
                 * 
                 * */
                while (current != null && current.Value.CompareTo(item) > 0)
                {
                    current = current.Next;
                }

                if (current == null)
                {
                    //We made it to the end of the list.
                    items.AddLast(item);
                }
                else
                {
                    /***
                     * the current item is <= the one being added
                     * so add the item before it.
                     * */

                    items.AddBefore(current,item);
                }
            }
        }
        #endregion Enqueue Function
        #region Dequeue Function

            /** Removes and returns the highest priority item from the queue
            * The front item from the queue
            **/

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty. ");
            }

            // store the last value in a temporaty variable.
            T value = items.First.Value;

            // removes the last item.
            items.RemoveFirst();

            //return the stored last value.
            return value;
        }
        #endregion Dequeue Function
        #region Peek Function
            
            /**
             * Returns the highest priority item from the queue without removing it from the queue
             * The front item from the queue. 
             * */

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty ");
            }

            return items.First.Value;
        }

        #endregion Peek Function
        #region Count Function
        // The number of items in the queue.

        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        #endregion Count Function
        #region Clear Function

        /**
         * Removes all items from the queue.
         * */

        public void Clear()
        {
            items.Clear();
        }

        #endregion Clear Function
        #region Enumerator Function
        
        l/**
         * Returns an enumerator that enumerates the queue
         * The enumerator
         * */

        public System.Collections.Generic.IEnumerator<T>GetEnumerator()
        {
            return items.GetEnumerator();
        }

        /**
         * Returns an enumerator that enumerates the queue
         * The enumerator.
         * */

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
        #endregion Enumerator Function
    }
}
