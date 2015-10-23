using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkFour.cs
{
    class FirstLargerThanNeighbours
    {
        /*
         * First Larger Than Neighbours
         * */

        static int[] arr;

        static void Main(string[] args)
        {
            #region input

            string inputArray = Console.ReadLine();
            arr = inputArray.Split().Select(int.Parse).ToArray();
            bool isGreater = false;


            #endregion Input
            #region Main () Logic

            for (int i = 0; i < arr.Length; i++)
            {
                if (GetFirstLarger(i))
                {

                    Console.WriteLine("First Larger element is {0}",i);
                    isGreater = true;
                    break;
                }

                if (!isGreater)
                {
                    Console.WriteLine("-1");
                }
            }

            #endregion Main () Logic
        }

        #region Logic

        static bool GetFirstLarger(int idx)
        {
            bool firstLarger;

            if (idx == 0)
            {
                firstLarger = arr[idx] > arr[idx + 1];
            }

            else if (idx == arr.Length - 1)
            {
                firstLarger = arr[idx] > arr[idx - 1];
            }

            else
            {
                firstLarger = arr[idx] > arr[idx - 1] && arr[idx] > arr[idx + 1];
            }

            return firstLarger;

        }

        #endregion Logic

        #region Output
        #endregion Output



    }
}
