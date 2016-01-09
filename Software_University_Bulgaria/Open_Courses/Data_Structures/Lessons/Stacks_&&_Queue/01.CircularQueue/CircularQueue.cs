using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CircularQueue
{
    class CircularQueue
    {
        public class CircularQueue<T>
        {
            #region Input Data
            private T[] elements;
            private int startIndex = 0;
            private int endIndex = 0;

            private const int InitialCapacity = 16;
            #endregion Input Data
            #region Count Function
            public int Count
            {
                get;
                private set;
            }
            #endregion Count Function
            #region CircularQueue Function
            public CircularQueue(int capacity = InitialCapacity)
            {
                this.elements = new T[capacity];
            }
            #endregion CircularQueue Function
            #region CopyAllElementsTo Function
            private void CopyAllElementsTo(T[] resultArr)
            {
                int ourceIndex = this.startIndex;
                int destinationIndex = 0;
                    for (int i = 0; i < this.Count; i++)
                         {
                             resultArr[destinationIndex] = this.elements[sourceIndex];
                             sourceIndex = (sourceIndex + 1) % this.elements.Length;
                             nextIndex = (sourceIndex + 1) % this.elements.Length;
                             destinationIndex++;
                         }
            }

            #endregion CopyAllElementsTo Function
            #region Grow Function
            private void Grow()
            {
                var newElements = new T[2 * this.elements.Length];
                this.CopyAllElementsTo(newElements);
                this.elements = newElements;
                this.startIndex = 0;
                this.endIndex = this.Count;
            }
            #endregion Grow Function
            #region Enqueue Function
            public void Enqueue(T element)
            {
                if (this.Count >= this.elements.Length)
                {
                    this.Grow();
                }

                this.elements[this.endIndex]=element;
                this.endIndex = (this.endIndex + 1) % this.elements.Length;
                this.Count++;

            }
            #endregion Enqueue Function
            #region Dequeue Function
            public T Dequeue()
            {
                if (this.Count == 0)
                {
                    throw new InvalidOperationException("The queue is empty!...");
                }

                var result = this.elements[startIndex];
                this.startIndex = (this.startIndex + 1) % this.elements.Length;
                this.Count--;
                
                return result;
            }
            #endregion Dequeue Function
            #region ToArray Function
            public T[] ToArray()
            {

            }
            #endregion ToArray Function

        }


        static void Main(string[] args)
        {



        }
    }
}
