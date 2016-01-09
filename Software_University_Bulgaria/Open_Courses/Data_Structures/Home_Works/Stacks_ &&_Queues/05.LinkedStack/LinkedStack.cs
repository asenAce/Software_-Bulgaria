using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LinkedStack
{
    public  class LinkedStack<T>
    {
        #region class Node

        private class Node<T>
        {
            /**
             * Private T value; with proparties.
             * 
             * */

            #region Value

            public T Value
            {
                get;
                private set;
            }

            #endregion Value
            #region NextNode
            public Node<T> NextNode
            {
                get;
                set;
            }
            #endregion NextNode
            #region Node
            public Node(T value, Node<T> nextNode = null)
            {
                this.Value = value;
                this.NextNode = nextNode;
            }
            #endregion Node
        }

        private Node<T> firstNode;
        #region Count
        public int Count
        {
            get;
            private set;
        }
        #endregion Count
        #region Push
        public void Push(T element)
        {
            if (this.Count == 0 )
            {
                this.firstNode = new Node<T>(element);
            }

            else
            {
                this.firstNode = new Node<T>(element,this.firstNode);
            }
            this.Count++;
        }
        #endregion Push
        #region Pop
        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("the stack is empty");
            }

            var resultNode = firstNode;
            firstNode = firstNode.NextNode;
            this.Count--;
            return resultNode.Value;
        }
        #endregion Pop
        #region ToArray
        public T[] ToArray()
        {
            var arrReturn = new T[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                arrReturn[i] = firstNode.Value;
                firstNode = firstNode.NextNode;
            }

            return arrReturn;
        }
        #endregion ToArray
        #endregion class Node
    }
}
