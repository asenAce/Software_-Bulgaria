using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class Square
    {
        int num;

        public Square(int num)
        {


        }

        public int Num 
        {
            get
            {
                return this.num;
            }
            set
            {
                this.num = value;
            }
        }


        // Simple Method to Calculate the Square
        public double CalculateTheSquare(int num)
        {
            double theResult;
            theResult = Math.Sqrt(num);
            return theResult;
        }

    }
}
