using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Array
{
      public class Queue<T> : System.Collections.Generic.IEnumerable<T>
      {
        T[] items = new T[0];

          //the number of items in the queue
        int size = 0;

          //the index of the first (oldest) item in the queue
        int head = 0;

          //the index of the last (newest) item in the queue.
        int tail = -1;

        #region Enqueue Function
          //Add an item to the back of the queue
          //The item to place in the queue

          public void Enqueue(T item)
        {
              //If the array needs to grow.
            if (items.Length == size)
            {
                int newLength = (size == 0) ? 4 : size * 2;

                T[] newArray = new T[newLength];

                if (size > 0)
                { 
                     /**
                      * copy contents....
                      * if the array has no wrapping ,just copy the valid range.
                      * else copy from head to end of the array and then from 0 to the tail.
                      * if tail is less than head we have wrapped.
                      * */

                    int targetIndex = 0;

                    if (tail < head)
                    {
                        // copy the items[head]....items[end] --> newArray[0]...newArray[N]

                        for (int index = head; index < items.Length; index++)
                        {
                            newArray[targetIndex] = items[index];
                            targetIndex++;
                        }

                        // copy items[0]...items[tail] -> newArray[N+1]...
                        for (int index = 0; index <= tail; index++)
                        {
                            newArray[targetIndex] = items[index];
                            targetIndex++;
                            
                        }

                    }

                    else
                    {
                        // copy  the items[head]...items[tail] --> newArray[0]...newArray[N]

                        for (int index = head; index <= tail; index++)
                        {
                            newArray[targetIndex] = items[index];
                            targetIndex++;
                        }
                    }

                    head = 0;
                    tail = targetIndex - 1; // compensate for the extra bump

                }
                else
                {
                    head = 0;
                    tail = -1;
                }

                items = newArray;
            }

              // now we have a properly sized array and can focus on wrapping isues.
              // if tail is at the end of the array we need to wrap around.

            if (tail == items.Length - 1)
            {
                tail = 0;
            }
            else
            {
                tail++;
            }

            items[tail] = item;
            size++;
        }
        #endregion Enqueue Function
        #region Dequeue Function
          // Removes and returns the front item from the queue
          // The front item from the queue

          public T Dequeue()
          {
              if (size == 0 )
              {
                  throw new System.InvalidOperationException("The queue is empty");
              }

              T value = items[head];

              if (head == items.Length-1)
              {
                  // if the head is at the last index in the array -wrap around.
                  head = 0;
              }

              else
              {
                  // move to the next value.
                  head++;
              }
              size--;
              return value;
          
          }
        #endregion Dequeue Function
        #region Peek Function
          //Returns the front item from the queue without removing it from the queue
          //The front item from the queue

          public T Peek()
          {
              if (size == 0)
              {
                  throw new System.InvalidOperationException("The queue is empty");
              }

              return items[head];
          }
        #endregion Peek Function
        #region Count Function
          // The number of items in the queue
          public int Count
          {
              get
              {
                  return size;
              }
          }
        #endregion Count Function
        #region Clear Function
          //Removes all items from the queue

          public void Clear()
          {
              size = 0;
              head = 0;
              tail = -1;
          }
        #endregion Clear Function
        #region Enumerator Function
          //Returns an Enumerator that enumerates the queue
          //The enumerator

          public System.Collections.Generic.IEnumerator<T> GetEnumerator()
          {
              if (size > 0)
              {
                  // if the queue wraps then handle that case
                  if (tail < head)
                  {
                      //head --> end
                      for (int index = head; index < items.Length; index++)
                      {
                          yield return items[index];
                      }

                      // 0 --> tail
                      for (int index = 0; index <= tail; index++)
                      {
                          yield return items[index];
                      }
                      

                  }

                  else
                  {
                      // head -> tail
                      for (int index = head; index <= tail; index++)
                      {
                          yield return items[index];
                              
                      }
                  }
              }

          }
        #endregion Enumerator Function
          // Returns an enumerator that enumerates the queue
          // The Enumerator

          System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
          {
              return GetEnumerator();
          }


      }
}
