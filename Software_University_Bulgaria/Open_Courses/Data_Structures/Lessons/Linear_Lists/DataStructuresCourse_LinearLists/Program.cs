using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCourse_LinearLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> argsList = new List<string>(args);

           // List<int> primesList = new List<int>(new int[]{1,2,3,5,7,11});
           // or

            List<int> primesList = new List<int>()
            {
                1,2,3,4,5,6,7,8,
            };

            Console.WriteLine(primesList[3]);  // [3] implementator element 3+1 [3]  ...[0]...[1]...[2]...[3] print the element 
            // on possition 3+1  indexant [..]
            primesList[3] = -primesList[3];

            Console.WriteLine(primesList[3]);

            // passThrow each element in the List<>;
            foreach (var primeNumber in primesList)
            {
                Console.WriteLine(primeNumber);
            }

            // second variant

            for (int i = 0; i < primesList.Count; i++)      // .Count not !! Lenght
            {
                Console.WriteLine(primesList[i]);
            }

            // Adding elements to the List<>;
            primesList.Add(13);
            primesList.Add(7);
            primesList.Add(10);

            for (int i = 0; i < primesList.Count; i++)      // .Count not !! Lenght
            {
                Console.WriteLine(primesList[i]);
            }

        }
    }
}
