using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
   // [ Version(0,1)]
   public class GenericList<T>
    {
       [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Method)]

       public const int DEFAULTLISTCAPACITY = 16;
       private T[] array;
       private int count = 0;

       int initialCapacity;
       int count;
       int capacity;

       public GenericList(int initialCapacity = DEFAULTLISTCAPACITY)
       {
           this.array = new T[initialCapacity];
       }

       //Holds the numbers of elements that have been added to the GenericList
       public int Count 
       {
           get
           {
               return this.Count;
           }
          private set
           {
               this.Count = value;
           }
       }

       //Capacity Holds the current capacity of the GenericList.If the numbers/elements/ exeeds the list capacity ,the capacity is doubled. 
       public int Capacity 
       {
           get
           {
               return this.capacity;
           }
           
       }

       public T this[int index]
       { 
           get
           {
               if (index < 0 || this.Count <= index)
               {
                   throw new IndexOutOfRangeException("Outside the boundries of the generic list.");
               }

               return this.array[index];
           }
           
       }

       public static T Min<T>(GenericList<T> list)
           where T: IComparable
       {

           T min = default(T);

           for (int index = 0; index < list.Count; index++)
           {
               if (min.CompareTo(default(T)) == 0 || min.CompareTo(list[index]) == 1)
               {
                   min = list[index];
               }
           }

           return min;
       }

       public static T Max<T>(GenericList<T> list)
          where T : IComparable
       {

           T max = default(T);

           for (int index = 0; index < list.Count; index++)
           {
               if (max.CompareTo(default(T)) == 0 || max.CompareTo(list[index]) == 1)
               {
                   max = list[index];
               }
           }

           return max;
       }

       //Elements to be added;

       public void Add(T elementToAdd)
       {
           if (this.Count + 1 >= this.array.Length )
           {
               this.ResizeList();
           }

           this.array[this.Count] = elementToAdd;

           this.Count++;

       }

       private void ResizeList()
       {
           throw new NotImplementedException();
       }


       public void RemoveAt(int index)
       {
           if (index < 0 || this.Count <= index)
           {
               throw new IndexOutOfRangeException("Incorrect");
           }

           T[] newArray = new T[this.array.Length];
           Array.Copy(this.array,0,newArray,0,index);
           Array.Copy(this.array,index + 1,newArray,index,this.Count - index - 1);

           this.Count--;
           this.array = newArray;

       }

       //Insert the new element at a specified index.
       //If there are empty positions between the index and the currect last element,these positions are filled with default values 
       //depending on the type of the list.
       //the index where the new element will be inserted.
       //the element which will be added to the list.

       public void InsertAt(int index,T newElement)
       {

           if (index < 0)
           {
               throw new IndexOutOfRangeException("Index is Outside the boundries of the generic list.");
           }

           int size = this.Capacity;

           while (index + 1 >= size)
           {
               size *= 2;
           }

           T[] newArray = new T[size];
           Array.Copy(this.array,0,newArray,0,index);
           newArray[index] = newElement;

           if (index > this.Count)
           {
               this.Count = index + 1;
           }

           else
           {
               this.Count++;
               Array.Copy(this.array,index,newArray,index + 1,this.Count - index - 1);
           }

           this.array = newArray;

       }

       //Clear
       public void Clear()
       {
           this.array = new T[this.array.Length];
       }

       /// <summary>
       /// Searches for the first occurrence of the specified element in the list and returns its index if found, -1 otherwise.
       /// Compares value types by value and reference types by reference.
       /// </summary>
       /// <param name="elementToFind">The element to search for.</param>
       /// <returns>The zero-based index of the element or -1 if the element isn't found in the list.</returns>
       public int IndexOf(T elementToFind)
       {
           for (int index = 0; index < this.Count; index++)
           {
               if (object.ReferenceEquals(this.array[index], elementToFind))
               {
                   return index;
               }

               if (typeof(T).IsValueType && this.array[index].Equals(elementToFind))
               {
                   return index;
               }
           }

           return -1;
       }

       /// <summary>
       /// Searches for the last occurrence of the specified element in the list and returns its index if found, -1 otherwise.
       /// Compares value types by value and reference types by reference.
       /// </summary>
       /// <param name="elementToFind">The element to search for.</param>
       /// <returns>The zero-based index of the element or -1 if the element isn't found in the list.</returns>
       public int LastIndexOf(T elementToFind)
       {
           for (int index = this.Count - 1; index >= 0; index--)
           {
               if (object.ReferenceEquals(this.array[index], elementToFind))
               {
                   return index;
               }
           }

           return -1;
       }

       public bool Exists(T elementToCheck)
       {
           bool exists = this.IndexOf(elementToCheck) != -1;
           return exists;
       }

       public override string ToString()
       {
           StringBuilder result = new StringBuilder();
           result.Append("{");

           for (int i = 0; i < this.Count; i++)
           {
               result.Append(this[i]);

               if (i != this.Count - 1)
               {
                   result.Append(", ");
               }
           }

           result.Append("}");

           return result.ToString();
       }

       private void ResizeList()
       {
           int newArraySize = this.array.Length * 2;
           T[] newArray = new T[newArraySize];

           Array.Copy(this.array, newArray, this.array.Length);
           this.array = newArray;
       }


    }
}
