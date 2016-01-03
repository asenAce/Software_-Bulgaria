using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.OrderBy
{
    class OrderBy
    {
        static void Main(string[] args)
        {
            /*
             * This programe sorted numbers in a List , only those which are divided by %3
             * 
             * */


            // Creating a List

            List<int> list = new List<int>
            {   // Pass the values in the list 
                1,2,3,4,5,6
                //1,2,0,1,2,0
            };

            // the block code that hendle this !
            // list is the non fix masive with ID list of type <int> . dot separetor calling a Method which is a Method of an Object
            //remember in OOP everything is an Object and the Object has  a Methods like characteristics of it after the Methods
            // came or we pass the parameters () without anything in it is called empty parameters in this case the parameter has
            // inf which is  ... take the value (v) and movie it => to v every number which is dividet to 3 %3.

            var ordered = list.OrderBy((v) => v % 3).ThenByDescending((v) => v);

            Console.WriteLine(String.Join(", ",ordered));


        }
    }
}
