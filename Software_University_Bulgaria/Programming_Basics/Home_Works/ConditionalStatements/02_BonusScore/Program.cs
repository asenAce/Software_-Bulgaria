using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    /**
     * Write a program that applies bonus score to given score in the range [1…9]
     * by the following rules:
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please state the score from 1 to 9:   ");
            int score = int.Parse(Console.ReadLine());  // int because must be a hole number!

            /**
             * The formulas for adding extra bounuce to the score variable: 
             * */
            int scoreOne= score*10; 
            int scoreTwo= score*100;
            int scoreThree= score*1000;

             

           switch(score)
           {
                   /**
                    * Implementing multipul cases:
                    * compare score to numbers 1,2,3 if yes execute this code of block.
                    * */
               case 1:
               case 2:
               case 3:
                       Console.WriteLine("The total score is {0}",scoreOne);
                   break;
               case 4:
               case 5:
               case 6:
                       Console.WriteLine("The total score is {0}",scoreTwo);    
                   break;        
               case 7:
               case 8:
               case 9:  
                   Console.WriteLine("The total score is {0}",scoreThree);
                   break;
               default:
                   Console.WriteLine("Sorry unvalid score,please try again. ");
                   break;
   
           }
           Console.ReadLine();


        }
    }
}
