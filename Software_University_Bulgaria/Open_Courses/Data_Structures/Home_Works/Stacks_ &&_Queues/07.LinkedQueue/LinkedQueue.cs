
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LinkedQueue
{
    #region LinkedQueue Class

    public  class LinkedQueue <T>
    {
        #region The Input
        private QuequNode<T> head;
        private QuequNode<T> tail;
        #endregion The Input
        #region Count 
        public int Count
        {
            get;
            private set;
        }
        #endregion Count
        #region Enqueue Function
        public void Enqueue(T element)
        {
            if (this.Count == 0)
            {
                this.head = new QuequNode<T>(element);
                this.tail = this.head;

            }

            else
            {
                var newElement = new QuequNode<T>(element);
                newElement.NextNode = this.head;
                this.head.PrevNode = newElement;
                this.head = newElement;
            }
            this.Count++;
        }
        #endregion Enqueue Function
        #region Dequeue Function
        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            var resultEl = this.tail.Value;
            this.tail = this.tail.PrevNode;

            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }

            else
            {
                this.head = null;
            }

            this.Count--;
            return resultEl;
        }
        #endregion Dequeue Function
        #region ToArray Function
        public T[] ToArray()
        {
            var resultArr = new T[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                resultArr[i] = this.tail.Value;
                this.tail = this.tail.PrevNode;
            }

            return resultArr;
        }
        #endregion ToArray Function
        #region QuequNode
        private class QuequNode<TQ>
        {
            public TQ Value
            {
                get;
                private set;
            }

            public QuequNode<TQ> NextNode
            {
                get;
                set;
            }

            public QuequNode<TQ> PrevNode
            {
                get;
                set;
            }

            public QuequNode(TQ value)
            {
                this.Value = value;
            }
        }
        #endregion QuequNode

    }
    #endregion LinkedQueue
}
