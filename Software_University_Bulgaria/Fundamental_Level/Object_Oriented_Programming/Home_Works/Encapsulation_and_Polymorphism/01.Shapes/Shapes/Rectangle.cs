using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes.Shapes
{
    class Rectangle : BasicShape
    {

        public Rectangle(double width,double height)
            : base(width,height)
        {



        }

        public override double CalculateArea()
        {

            double resultArea;
            resultArea = this.Width * this.Height;
            return resultArea;

        }

        public override double CalculatePerimeter()
        {
            double resultPerimeter;
            resultPerimeter = 2 *(this.Width + this.Height);
            return resultPerimeter;
        }


    }
}
