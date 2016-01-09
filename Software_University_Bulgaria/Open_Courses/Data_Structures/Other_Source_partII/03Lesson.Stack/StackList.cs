using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Lesson.Stack
{
    class StackList
    {
        // A Last In First Out (LIFO) collection implemented as a linked list.
        //The type of item contained in the stack


    }

    #region Stack

    public class Stack<T> : System.Collections.Generic.IEnumerable<T>
    {
        //Alocate the List<>
        private System.Collections.Generic.LinkedList<T> _list = new System.Collections.Generic.LinkedList<T>();
        //  Adds the specified item to the stack.
        // The item
        #region Add
        public void Push(T item)
        {
            _list.AddFirst(item);
        }
        #endregion Add
        #region Remove
        //Remove and returns the top item from the stack
        //The top-most item in the stack.

        public T Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty ");
            }

            T value = _list.First.Value;
            _list.RemoveFirst();

            return value;
        }
        #endregion Remove

        #region Peek
        public T Peek()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return _list.First.Value;
        }
        #endregion Peek

        
        #region Count
        // The current number of items in the stack
        public int Count
        {
            get
            {
                return _list.Count;
            }
        }
        #endregion Count
        
        #region Clear
        //Removes all items from the stack
        public void Clear()
        {
            _list.Clear();
        }
        #endregion Clear
        #region Enumerator
        //Enumerates each item in the stack in LIFO order.The stack remains unaltered.
        //The LIFO enumerator.
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
        //Enumerates each item in the stack in LIFO order.The stack remains unaltered.
        //The LIFO enumerator.
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        #endregion Enumerator
    }
#endregion Stack

}
