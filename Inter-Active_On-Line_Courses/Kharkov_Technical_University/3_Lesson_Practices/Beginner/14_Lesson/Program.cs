using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14.Lesson.array
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Scores is a variable; it refers to an array
             * of five elements, all string variables.
             * We use an indexer to access the individual variable.
             * 
             * */
            string[] scores =                // type [] ID = {}; "" , "" ,
            {
                "love",
                "fifteen",
                "thirty",
                "forty",
                "game",
            };

            Console.WriteLine(scores[0]);   // Index access
            Console.WriteLine(scores[1]);
            Console.WriteLine(scores[2]);
            Console.WriteLine(scores[3]);
            Console.WriteLine(scores[4]);
        
            //   out of bounce!
            //   Console.WriteLine(scores[5]);

            //Length property
            Console.WriteLine(scores.Length);

            //for loops are tailor-made for arrays
            for (int index = 0; index < scores.Length; index+=1)
            {
                Console.WriteLine(scores[index]);
            }

            // foreeach do not care about the index.
            // Syntax for foreach (type element in collection)
            // body.  the type either names a type or is var.
            //The element is the name of the loop variable.
            //The collection is an expression.
            // The body is a statement. 

            foreach (string  score in scores)
            {
                Console.WriteLine(score);
            }

            /**
             * Array elements are variables,so we can change their values.
             * */
            scores[0] = "zero";
            Console.WriteLine(scores[0]);

            // Array initializers are special:
            int[] abc = { 10,20,30};
            int[] def;

            def = new int[] { 10,20,30};


        }
    }
}
