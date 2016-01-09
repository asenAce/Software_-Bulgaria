using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Lesson_NodeChains
{
   public class NodeTwo
    {

            // Instantiate int Value , get;set;
            public int Value
            {
                get;
                set;
            }
            //Instantiate ID Next
            public NodeTwo Next
            {
                get;
                set;
            }

            //Creating the Node with ID first with the Value = 3.

            NodeTwo first = new NodeTwo
            {
                Value = 3
            };

            NodeTwo middle = new NodeTwo
            {
                Value = 5
            };

            NodeTwo last = new NodeTwo
            {
                Value = 7
            };

          //  first.Next = middle;
          //  middle.Next = last;       do conection 5 --> 7
      
    }
}
