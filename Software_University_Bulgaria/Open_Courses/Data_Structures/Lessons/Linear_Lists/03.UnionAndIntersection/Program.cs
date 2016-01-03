using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnionAndIntersection
{
    class Program
    {
        //Lesson 03 UnionAndIntersection

        int Union = int.Parse(Console.ReadLine());


        int[] Union (int[] firstArray, int[] secondArray)
        {
            List<int> union = new List<int>();

            union.AddRange(firstArray);

            foreach (var item in secondArray)
            {
                if (! union.Contains(item))
                {
                    union.Add(item);

                    return union.ToArray();
                }
            }

             
        }

        int[] Intersection(int[] firstArray, int[] secondArray)
        {
            List<int> intersection = new List<int>();
            foreach (var item in firstArray)
            {
                if (Array.IndexOf(secondArray,item) !=-1)
                {
                    intersection.Add(item);
                }

                return intersection.ToArray();
                
            }

        }



        static void Main(string[] args)
        {




        }
    }
}
