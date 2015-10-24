using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cubes
{
    public class Cubes
    {
        private static int CubesCount = 0;
        private static readonly HashSet<string> Used = new HashSet<string>();

        public static void Main(string[] args)
        {
            var elements = Console.ReadLine()
                .Split()
                .ToList();

            elements.Sort();
            Permute(elements);

            Console.WriteLine(CubesCount);
        }

        private static string[] RotateYZ(string[] currentCube)
        {
            string[] temp = new string[12];

            temp[0] = currentCube[8];
            temp[1] = currentCube[4];
            temp[2] = currentCube[0];
            temp[3] = currentCube[7];

            temp[4] = currentCube[9];
            temp[5] = currentCube[1];
            temp[6] = currentCube[3];
            temp[7] = currentCube[11];

            temp[8] = currentCube[10];
            temp[9] = currentCube[5];
            temp[10] = currentCube[2];
            temp[11] = currentCube[6];

            return temp;
        }

        private static string[] RotateXZ(string[] currentCube)
        {
            string[] temp = new string[12];

            temp[0] = currentCube[4];
            temp[1] = currentCube[9];
            temp[2] = currentCube[5];
            temp[3] = currentCube[1];

            temp[4] = currentCube[8];
            temp[5] = currentCube[10];
            temp[6] = currentCube[2];
            temp[7] = currentCube[0];

            temp[8] = currentCube[7];
            temp[9] = currentCube[11];
            temp[10] = currentCube[6];
            temp[11] = currentCube[3];

            return temp;
        }

        private static string[] RotateXY(string[] currentCube)
        {
            string[] temp = new string[12];

            temp[0] = currentCube[3];
            temp[1] = currentCube[0];
            temp[2] = currentCube[1];
            temp[3] = currentCube[2];

            temp[4] = currentCube[7];
            temp[5] = currentCube[4];
            temp[6] = currentCube[5];
            temp[7] = currentCube[6];

            temp[8] = currentCube[11];
            temp[9] = currentCube[8];
            temp[10] = currentCube[9];
            temp[11] = currentCube[10];

            return temp;
        }

        private static void Permute(List<string> array, int start = 0)
        {
            var current = string.Join(",", array);
            MarkUsedCubes(current);

            if (!Used.Contains(current))
            {
                CubesCount++;
            }

            if (start < array.Count)
            {
                for (int i = array.Count - 2; i >= start; i--)
                {
                    string tmp;
                    for (int j = i + 1; j < array.Count; j++)
                    {
                        if (array[i] != array[j])
                        {
                            // swap
                            tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;

                            Permute(array, i + 1);
                        }
                    }

                    // Undo all modifications done by recursive calls and swapping
                    tmp = array[i];
                    for (int k = i; k < array.Count - 1; k++)
                    {
                        array[k] = array[k + 1];
                    }

                    array[array.Count - 1] = tmp;
                }
            }
        }

        private static void MarkUsedCubes(string check)
        {
            var currentCube = check.Split(',').ToArray();

            for (int j = 0; j < 4; j++)
            {
                currentCube = RotateXY(currentCube);
                for (int k = 0; k < 4; k++)
                {
                    currentCube = RotateXZ(currentCube);
                    for (int l = 0; l < 4; l++)
                    {
                        currentCube = RotateYZ(currentCube);

                        var rotatedEquivalent = string.Join(",", currentCube);

                        if (rotatedEquivalent != check)
                        {
                            Used.Add(rotatedEquivalent);
                        }
                    }
                }
            }
        }
    }
}
