using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array
{
    //A Last In FirstOut(LIFO) Collection implemented as an Array.
    //The type of item contained in the stack. 

   public class Stack<T> : System.Collections.Generic.IEnumerable<T>
    {
       /*The Array of items contained in the stack.Initialized to O length,will grow as needed during Push.
        * 
        * */
       T[] items = new T[0];

       //The currnet number of items in the stack.
       int size;

       /**
        * Adds the specified item to the stack.
        * The item.
        * */
        #region Add
       public void Push(T item)
       {
           /**
            * size = 0 .... first push.
            * size == length.....growth boundary.
            * */
           if (size == items.Length)
           {
               //initial size of 4,otherwise double the current length
               int newLength = size == 0 ? 4 : size * 2;

               //allocate,copy and assign the new array.
               T[] newArray = new T[newLength];
               items.CopyTo(newArray,0);
               items = newArray;
           }
           //add the item to the stack array and increase the size.
           items[size] = item;
           size++;
       }
        #endregion Add
        #region Pop
       /**
        * Removes and returns the top item from the stack.
        * The top-most item in the stack.
        * */
       public T Pop()
       {
           if (size == 0)
           {
               throw new InvalidOperationException("The stack is empty.");
           }
           size--;
           return items[size];
       }
        #endregion Pop
        #region Peek
       /**
        * Returns the top item from the stack without removing it from the stack
        * The top-most item in the stack.
        * */
       public T Peek()
       {
           if (size == 0)
           {
               throw new InvalidOperationException("The stack is empty.");
           }

           return items[size - 1];
       }
        #endregion Peek
        #region Count 
       /**
        * The current number of items in the stack. 
        * */
       public int Count
       {
           get
           {
               return size;
           }
       }
        #endregion Count
        #region Clear
       /**
        * Removes all items from the stack.
        * */
       public void Clear
       {
           size = 0;
       }
        #endregion Clear
        #region Enumerator
       /**
        * Enumerates each item in the stack in LIFO order. The stack remains unaltered.
        * The LIFO Enumerator
        * */
       public System.Collections.Generic.IEnumerator<T> GetEnumerator()
       {
           for (int i = size-1; i >=0 ; i--)
			{
			    yield return items[i]; 
			}
       }

       /**
        * Enumerates each item in the stack in LIFO order.The stack remains unaltered.
        * The LIFO  Enumerator
        * */
       System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
       {
           return GetEnumerator();
       }


        #endregion Enumerator


    }



}
