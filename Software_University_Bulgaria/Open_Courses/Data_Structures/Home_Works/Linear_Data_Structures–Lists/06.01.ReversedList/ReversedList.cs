using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._01.ReversedList
{
    //<summary>
    //Data structure ReversedList<T> thta holds a sequence of elements of generic type T.
    //It holds a sequence of items in revers.
    //<sumary>
    //<typeparam name = "T"></typeparam>

    public class ReversedList<T> : IEnumerable<T>
    {
        private T[] innerCollection;
        private long start;
        private long end;

        public ReversedList(long capacity = 1)
        {
            this.start = 0;
            this.end = 0;
            this.Capacity = capacity;
            this.innerCollection = new T[this.Capacity];

        }

        //<summary>
        //Holds the number of elements in the structure
        //</summary>

        public long Count
        {
            get;
            private set;
        }

        public long Capacity
        {
            get;
            private set;
        }

        public T this[long index]
        {
            get
            {
                if (index < start || index > this.end)
                {
                    throw new ArgumentOutOfRangeException("index",index,"The index is outside the range of the inner collection.");
                }

                return this.innerCollection[index];
            }

            set
            {
                if (index < start || index > this.end)
                {
                    throw new ArgumentOutOfRangeException("index",index,"The index is outside the range of the inner collection.");
                }

                this.innerCollection[index] = value;
            }
        }

        // <summary>
        // Adds an element to the sequence.Grow twice the underlying array to extend its capacity in case the capacity is full.
        //<summary>
        // <param name="item"></param>

        public void Add(T item)
        {
            if (this.end >= this.Capacity)
            {
                this.DoubleCapacity();
            }

            this.innerCollection[this.end]=item;
            this.Count++;
            this.end++;
        }

        // <summary>
        // Removes an element by index (in range 0...Count-1) in the reverse order of adding 
        // <summary>
        //<param name = "index"></param>
        //<returns>Returns the removed element </returns>

        public T Remove(long index)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Could not remove element from empty list;");
            }

            if (index >= this.end)
            {
                throw new InvalidOperationException("Could not remove element from index bigger than or equal to the index  of the");
            }

            T removed;

            removed = this.innerCollection[this.end- index -1];

            for (long  i = this.end - index; i < this.end; i++)
            {
                this.innerCollection[i - 1] = this.innerCollection[i];
            }

            this.end--;
            this.Count--;
            return removed;

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (long i = this.end - 1; i >= this.start; i--)
            {
                yield return this.innerCollection[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void DoubleCapacity()
        {
            this.Capacity *= 2;
            T[] tempArr =new T[this.Capacity];
            Array.Copy(this.innerCollection,this.start,tempArr,0,this.Count);
            this.start = 0;
            this.end = this.Count;
            this.innerCollection = tempArr;

        }

    }
}
