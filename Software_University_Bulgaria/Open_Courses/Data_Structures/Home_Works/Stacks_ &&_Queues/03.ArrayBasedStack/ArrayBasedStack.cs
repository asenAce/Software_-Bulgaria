using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArrayBasedStack
{
    class ArrayBasedStack<T>
    {
        #region The Input
            // Declaring const capacity = 16;
        private const int InitialCapacity = 16;
        private T[] elements;
       
        #endregion The Input

        #region The Logic
        #region Count function
        public int Count
        {
            get;
            set;
        }
        #endregion Count function
        #region ArrayStack Function
        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }
        #endregion ArrayStack Function
        #region Push Function
        
        public void Push(T element)
        {   // Reach the max capacity of the array must grow +
            if (this.Count == this.elements.Length)
	            {
		            Grow();
	            }
            this.elements[this.Count] = element;
            this.Count++;
        }
        
        #endregion Push Function
        #region Pop Function

            public T Pop()
            {
                if (this.Count == 0)
                	{
		                throw new InvalidOperationException(" the stack is empty! ");
                	}
                this.Count--;
                return this.elements[this.Count];
            }

        #endregion Pop Function
        #region ToArray Function
            public T[] ToArray()
            {
                var arrResult = new T[this.Count];

                for (int possition = this.Count - 1, j = 0; possition >=0 ; possition--,j++)
		        	{
			            arrResult[j] = this.elements[possition];
		        	}
                return arrResult;
            }

        #endregion ToArray Function

        #region Grow Function
            private void Grow()
            {
                var newElements = new T[this.elements.Length * 2];
                Array.Copy(this.elements,newElements,this.Count);
                this.elements= newElements;
            }

        #endregion Grow Function
        #endregion The Logic

        #region The Output

        #endregion The Output


    }
}
