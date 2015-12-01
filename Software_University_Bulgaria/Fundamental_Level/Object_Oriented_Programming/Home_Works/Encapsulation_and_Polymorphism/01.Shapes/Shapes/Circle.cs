using _01.Shapes.IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes.Shapes
{
    class Circle : IShapes
    {

        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius 
        { 
            get
            {
                return this.radius;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentOutOfRangeException("radius","Incorect.");
                }

                this.radius = value;
            }
        }


        public double CalculateArea()
        {
            double resultArea;
            resultArea = Math.PI * this.Radius * this.Radius;
            return resultArea;
        }

        public double CalculatePerimeter()
        {
            double resultPerimeter;
            resultPerimeter = 2 * Math.PI * this.Radius;
            return resultPerimeter;
        }


    }
}
