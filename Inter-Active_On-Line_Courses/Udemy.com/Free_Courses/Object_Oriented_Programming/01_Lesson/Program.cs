using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfStudents = 4;  // const = constanta
            int[] scores = new int[numberOfStudents]; // int [] array = new array of integers 

            int totalScore = 0;
            foreach (int score in scores)
            {
                totalScore = totalScore + score;
            }

            double averageScore = (double)totalScore / scores.Length;
        }
    }
}
