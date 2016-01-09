using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * [x] Count
 * [x] Push()
 * [x] Pop()
 * [x] Peak()
 * [x] ToArray()
 * 
 * 
 * */
namespace _05._01.LinkedStack
{
    public class LinkedStack<T>
    {
        #region Node

        private class Node<E>
        {
            private E value;
            private Node<E> next;

            public Node<E> Next
            {
                get
                {
                    return this.next;
                }

                set
                {
                    this.next = value;
                }
            }

            public Node(E value)
            {
                this.value = value;
            }
            #region Value
            public E Value
            {
                get
                {
                    return this.value;
                }
                set
                {
                    this.value = value;
                }
            }
            #endregion Value
            

        }

        #endregion Node

        private int count;
        private Node<T> head;
        #region LinkedStack
        public LinkedStack()
        {
            this.count = 0;
            this.head = null;
        }
        #endregion LinkedStack
        #region Count
        public int Count
        {
            get
            {
                return this.count;
            }
        }
        #endregion Count
        #region Push

        /**
         * Adds element on top of the stack 
         * name = "value";
         * The value of the elemnt to add
         * */

        public void Push(T value)
        {
            var newNode = new Node<T>(value);

            if (head == null)
            {
                this.head = newNode;
            }

            else
            {
                newNode.Next = head;
                head = newNode;
            }

            count++;
        }
        #endregion Push
        #region Pop function

        /**
         * Remove and returns the top value of the stack 
         * Top element 
         * */

        public T Pop()
        {
            var topValue = head.Value;
            this.head = head.Next;
            this.count--;

            return topValue;
        }
        #endregion Pop function 
        #region Peek function

        /**
         * Returns the Top value of the stack 
         * Top element
         * */

        public T Peek()
        {
            return this.head.Value;
        }
        #endregion Peek function
        #region ToArray
        public T[] ToArray()
        {
            T[] array = new T[this.count];
            Node<T> currNode = this.head;
            int currIndex = 0;

            while (currNode != null)
            {
                array[currIndex] = currNode.Value;
                currNode = currNode.Next;
                currIndex++;
            }

            return array;
        }
        #endregion ToArray

    }
}
