using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01.ArrayStack
{
    #region Content
    /**
     * [x] Count
     * [x] Push()
     * [x] Pop()
     * [x] Peek()
     * [x] Clear()
     * [x] Contains()
     * [x] ToArray()
     * [x] OptimizeCapacity
     * */

    #endregion Content

    #region ArrayStack Class

    public  class ArrayStack
    {
        #region The Input
            // Declaring the variables
        private const int InitialCapacity = 16;
        private int count;
        private T[] elements;
        private int top;



        #endregion The Innput

        #region The Logic

        #region ArrayStack
        public ArrayStack()
        {
            this.elements = new T[InitialCapacity];
        }

        public ArrayStack(int InitialCapacity)
        {
            this.elements = new T[InitialCapacity];
        }
        #endregion ArrayStack
        #region Count functrion
        public int Count
        {
            get
            {
                return this.Count;
            }

        }

        #endregion Count functrion
        #region Push functrion
            public void Push(T item)
        {
            if (count == this.elements.Length)
            {
                OptimizeCapacity(true);
            }
            this.elements[top] = item;
            top++;
            count++;
        }
        #endregion Push functrion
        #region Pop function
            public T Pop()
            {
                if (count == 0)
                {
                    throw new InvalidOperationException("Can not Pop() value from empty stack!");
                }

                top--;
                count--;
                var returnValue = this.elements[top];
                this.elements[top] =default(T);

                if (count <= elements.Length / 2)
                {
                    OptimizeCapacity(false);
                }
                return returnValue;
            }

        #endregion Pop function
        #region Peek function
        public T Peek()
            {
                return this.elements[top -1];
            }

        #endregion Peek function
        #region Clear function
        public void Clear()
        {
            this.elements = new T[InitialCapacity];
            this.count = 0;
            this.top = 0;
        }
        #endregion Clear function
        #region Contains function
        public bool Contains(Task item)
        {
            for (int i = 0; i < top; i++)
            {
                if (elements[i].Equals(item) )
                {
                    return true;
                }
            }

            return false;
        }

        #endregion Contains function
        #region ToArray

        T[] array = new T[this.Count];

             for (int i = 0; i < this.count; i++)
			{
			    array[i] = this.elements[this.count - i - 1];
			}

            return array;
        #endregion ToArray
        #region OptimizeCapacity
        private void OptimizeCapacity(bool increase)
        {
            T[] newStack = null;

            if (increase)
	        {
		        newStack = new T[this.elements.Length * 2];
	        }

            else
	        {
                newStack = new T[this.elements.Length / 2];
        	}

            for (int i = 0; i < top; i++)
			{
			    newStack[i] = elements[i];
			}            

            this.elements = newStack; 

        }

        #endregion OptimizeCapacity
        #endregion The Logic

        #region The Output

        #endregion The Output


    }

    #endregion ArrayStack
}
