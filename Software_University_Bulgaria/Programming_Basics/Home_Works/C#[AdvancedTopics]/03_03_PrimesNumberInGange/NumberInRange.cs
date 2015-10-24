using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrimesNumberInGange
{

    /**
     * 
     * Write a method that calculates all prime numbers in given 
     * range and returns them as list of integers:
     * */
    class NumberInRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please state n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(" Please state m = ");
            int m = int.Parse(Console.ReadLine());

            int count = 0;

            FindPrimesInRange(n,m,count);

        }

         static void FindPrimesInRange( int n,int m , int count )
        {
            List<int> numbers = new List<int>();

             /**
            for (int i = 1; i <= 10; i++ )
            {
                if( 10%i ==0) //this is cetno
                {
                    
                }
            }

             **/

             if ( n < 0 || m < 0 )
             {
                 n=2;
             }

             if ( n == 0 || m ==0)
             {
                 n = 2;
             }

             if (m > n)
             {
                 Console.WriteLine("Empty list");
             }

             for ( int i = n;i <= m ;i++ )
             {
                 for (int j = 1; j <= i;j++ )
                 {

                     if( i %j ==0)
                     {
                         count++;
                     }

                     if( count > 2)
                     {
                         break;
                     }

                 }
                 if ( count <=2)
                 {
                     numbers.Add(i);
                 }
                 count = 0;

                 foreach( var item in numbers)
                 {
                     Console.WriteLine( item +  " ");
                 }
                 Console.WriteLine();
                 Console.ReadLine();

             }


        }
    }
}
