using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrimesInGivenRangetionSeconDeti

    // Need Help!
{
    class Program
    {

        //Program that calculates 
        //all prime numbers in given range and returns them as list of integers.

        static void Main(string[] args)
        {
            Console.WriteLine(" Please state the number  ");
            int theNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(FindPrimesInRange);
            Console.ReadLine();
            
        }

        // Declaring the Methods
        // The Method has two parameters!
        static List<int> FindPrimesInRange(int startNum, int endNum)
    {
            // I am declaring the list where i can store the value of theNumber.....
            List<int>Numbers = new List<int>();
            // The value given by the user goes to the variable Numbers ,so i can store it in the list<T>
            int theNumber = Numbers;
           

           
            // Put logic If to work , find the given number from the user is it - number is it prime is it odd ?
            // is it = 0 ; is it number at all?
            if (Numbers<0)
            {
                Console.WriteLine("Negatives Numbers not alowed !");
            }

            else if ( Numbers %2 == 0) // Check is the number is odd
            {
                Console.WriteLine("The given number is Odd");
            }
            else if( Numbers % 2 ==1) // Check is the number is prime
            {
                for ( int i = 0; Numbers > startNum && Numbers< endNum ; i++ )
                {
                    Console.WriteLine("Result: {}" ,Numbers);
                }

            }
            else if(Numbers == 0) //Chech is the number is  = 0;
            {
                Console.WriteLine("The given number is equal to  0 ;");
            }
            else 
            {
                Console.WriteLine("Sorry not a Number!");
            }

            Console.ReadLine();
    }
    }
}
