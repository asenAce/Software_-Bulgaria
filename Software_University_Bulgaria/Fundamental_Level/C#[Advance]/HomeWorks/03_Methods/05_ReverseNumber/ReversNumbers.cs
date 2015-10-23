using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Five.cs
{
    class ReversNumbers
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(ReversNum(number));
        }


        static double ReversNum(double num)
        {
            string number = num.ToString();
            char[] reverse = number.ToCharArray();
            Array.Reverse(reverse);

            string revNum = new string(reverse);
            double newNum = double.Parse(revNum);

            return newNum;
        }
    }
}
