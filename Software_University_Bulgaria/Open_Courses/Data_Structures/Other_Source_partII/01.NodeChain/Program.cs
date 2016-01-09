
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NodeChain
{
    #region begginingNode
    //First Create a object Node 

    public class Node  // Has two properties Value , Next
    {
         

        public int Value // This is the value
        {
            get;
            set;
        }

        public Node Next  // This is the pointer
        {
            get;
            set;
        }

        Node first = new Node   // ID first
        {
            Value = 3
        };

        /*
         * Representation
         *----------------------
         *+         |          +
         *+ Value   | Pointer  +
         *+   3     |  Null    +
         *----------------------
         * */

        //Creating the next node

        Node second = new Node  // ID second , the second Node
        {
            Value = 5
        };
        
        // Put first pointer to point to the next Node

        // first.Next=middle;

        Node third = new Node
        {
            Value = 10
        };


    #endregion enddingNode
    }

    #region Add to End
    /**
            Add to End
     * 
    public void AddLast(LinkedListNode<T> node)
{
            if(Count == 0)
     *      { 
     *          Head = node;
     *      }
     *      
     *      else
     *      {
     *          Tail.Next = node;
     *      }
     *      
     *      Tail = node;
     *      Count++;
}
    
    */
    #endregion

    #region Remove
    /*
     * public void RemoveLast()
     * {
     *      if(Count != 0 )
     *      {
     *          if(Count == 1)
     *          {
     *              Head = null;
     *              Tail = null;
     *          }
     * 
     *          else
     *          {
     *              LinkedListNode<T> current = Head;
     *              while(current.Next != Tail)
     *              {
     *                  current = current.Next;
     *              }
     *              
     *              current.Next = null;
     *              Tail = current;
     *          }
     * 
     *          Count--;
     *      }
     * 
     * }
     * 
     * 
     * 
     * */
    #endregion

    #region RemoveFirst

    /**
     * public void RemoveFirst()
     * {
     *      if(Count != 0)
     *      {
     *          Head = Head.Next;
     *          Count--;
     *          
     *          if(Count == 0)
     *          {
     *              Tail = null;
     *          }
     *      }
     * 
     * }
     * 
     * 
     * */

    #endregion

    #region Enumerate

    /**
     * System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
     * {
     *      LinkedListNode<T> current = Head;
     *      
     *      while(current != null)
     *      {
     *          yield return current.Value;
     *          current = current.Next;
     * 
     *      }
     * 
     * 
     * }
     * 
     * 
     * */

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }


  

}
