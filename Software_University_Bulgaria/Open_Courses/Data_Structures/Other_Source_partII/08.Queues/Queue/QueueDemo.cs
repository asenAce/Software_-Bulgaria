using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Queue
{
    /**
     * A First In First Out Collection.
     * The type of data stored in the collection.
     * */
    #region ClassQueue
    public  class QueueDemo<T> : System.Collections.Generic.IEnumerable<T>
    {
         /**
          * The queued items - the last list item is the newest queue item,the First is the oldest.
          * This is so LinkedList<T>.GetEnumerator "just work"
          * 
          * */
         System.Collections.Generic.LinkedList<T> items = new System.Collections.Generic.LinkedList<T>();
         #region Enqueue Function
         //Adds an item to the back of the queue
         //The item to place in the queue
         public void Enqueue(T item)
         {
             items.AddLast(item);
         }
         #endregion Enqueue Function
         #region Dequeue Function
         //Removes and return the front item from the queue
         //The front item from the queue.
         public T Dequeue()
         {
             if (items.Count == 0)
             {
                 throw new InvalidOperationException("The queue is empty.  ");
             }

             //  store the last value in a temporary variable.
             T value = items.First.Value;
             // remove the last item.
             items.RemoveFirst();

             // remove the stored last value.
             return value;
         }
         #endregion Dequeue Function
         #region Peek Function
         /**
          * Returns the front item from the queuen without removing it from the queue.
          * The front item from the queue
          * */
         public T Peek()
         {
             if (items.Count == 0)
             {
                 throw new InvalidOperationException("The queue is empty.");
             }
             // return the last value in the queue
             return items.First.Value;
         }
         #endregion Peek Function
         #region Count Function
         //The number of items in the queue
         public int Count
         {
             get
             {
                 return items.Count;
             }
         }
         #endregion Count Function
         #region Clear Function
         //Removes all items from the queue
         public void Clear()
         {
             items.Clear();
         }
         #endregion Clear Functionendregion
         #region Enumerator Function
         //Returns an Enumerator that enumerates the queue.
         public System.Collections.Generic.IEnumerator<T> GetEnumerator()
         {
             return items.GetEnumerator();
         }

         System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
         {
             return items.GetEnumerator();
         }

         #endregion Enumerator Function
    }
    #endregion ClassQueue

}
