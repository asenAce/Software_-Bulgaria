
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReversedList
{
    class ReversedList<T> : IEnumerable<T>
    {
        private const int defaultCapacity = 4;
        private int count = 0;
        private T[] elements;


        // constructor -> initial capacity

        public ReversedList(int capacity = defaultCapacity)
        {
            elements = new T[capacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.elements.Length;
            }
        }

        // accessing element by index

        public T this[int index]
        {
            get
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index:  " + index);
                }

                return this.elements[index];
            }

            set
            {
                if (index >= this.count || index <0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index : " + index);
                }

                this.elements[index] = value;
            }

        }

        // adding an element 

        public void Add(T element)
        {
            if (count == elements.Length)
            {
                OptimizeCapacity(true);
            }

            elements[count] = element;
            this.count++;
        }

        // removing element by index

        public void Remove(int index)
        {
            if (elements.Length == 2 * count)
            {
                OptimizeCapacity(false);
            }

            if (index >=count || index< 0)
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the array");
            }

            T[] helpArray = new T[elements.Length];
            Array.Copy(elements,0,helpArray,0,index);
            Array.Copy(elements,index+1,helpArray,index,elements.Length-index-1);
            this.elements = helpArray;
            this.count--;
        }

        // clearing the list 

        public void clear()
        {
            elements= new T[defaultCapacity];
            this.count = 0;
        }

        // resize "elements" array -> double size or half size

        private void OptimizeCapacity(bool increase)
        {
            int newSize = 0;
            if (increase)
            {
                newSize = count * 2;
            }

            else
            {
                newSize = elements.Length / 2;
            }

            Array.Resize<T>(ref elements,newSize);
        }

        // override Tostring for GenericList<T>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("{");

            for (int i = count -1; i >= 0; i--)
            {
                result.Append(elements[i]);
                if (i > 0)
                {
                    result.Append(",");
                }
            }
            result.Append("}");

            return result.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            int currentIndex = this.count - 1;

            while (currentIndex != 0 )
            {
                yield return elements[currentIndex];
                currentIndex--;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
