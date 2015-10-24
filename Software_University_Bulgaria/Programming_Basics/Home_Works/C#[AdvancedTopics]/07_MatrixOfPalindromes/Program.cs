using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MatrixOfPalindromes
{
    class Program
    {
        /**
         * Write a program to generate the 
         * following matrix of palindromes of 3 letters with r rows and c columns.
         * 
         * */
        static void Main(string[] args)
        {
            // Disection of a CODE!!
            //Step1. take the info from the user!
            Console.WriteLine(" Programe generate the following matrix of palindromes of 3 letters with r rows and c columns. ");
            Console.WriteLine("Write r = ;");
            //Step2.Store the info about the rolls in variable roll type integer . Parse
            int r = int.Parse(Console.ReadLine()); // r meen rows
            //Step3.Store the information about colloms in variable c type integer . Parse
            Console.WriteLine("Write c =  ;");  // c meen colums
            int c = int.Parse(Console.ReadLine());

            //Step.3 Create the matrix type string [] , one dimention ID matrix = assign operator
            // new operator type [] the matrix take two parameters r and c separeted with , 
                string [,] matrix = new string[r,c];

            //Step.4 Fill the matrix with palidromes
            // type chart = give a value '' a ; end off the command.
            char ch1 = 'a';
            // Nested for's  () condition variable i assign value = 0 meen start from 0
            // ; next condition i is less of rows ; incrementing the i ; {} in the block code!!

            for (int i = 0; i < r;i++ )
            {
                char ch2 = ch1;
                for (int j = 0; j < c;j++ )
                {
                    // Step.5  creating variable word ID from type string = assign value
                    //ch1 object . dot separetor ToString is a method of object ch1 taking empty
                    // parameters() ; end of command
                    string word = ch1.ToString() + ch2.ToString() + ch1.ToString(); // + combine all the variables
                    // matrix matrix with parameters [] i and j = variable word;
                    matrix[i,j]=word;
                    //incrementing of the object ch2++
                    ch2++;
                }
                ch1++;
                
            }
            // Step.6 Printing the Matrix on the console.
            // with placeHolder.
            Console.WriteLine("The matrix with {0} rows and {1} colums with palindromes is :", r, c);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }

        }
    }
}
