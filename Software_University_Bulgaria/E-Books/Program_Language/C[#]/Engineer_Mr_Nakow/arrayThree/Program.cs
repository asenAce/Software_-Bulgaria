using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a possitive integer:  ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter a value of the array:  ");

            for (int i = 0; i < n; i++ )
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            bool symmetric = true;

            for (int i = 0; i < array.Length / 2;i++ )
            {
                if( array[i] !=array[n- i -1])
                {
                    symmetric = false;
                }
            }
            Console.WriteLine(" Is symmetric? {0}",symmetric);
            Console.ReadLine();
        }
    }
}
