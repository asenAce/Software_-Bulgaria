using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes.Shapes
{
    class Triangle : BasicShape
    {

        private double sideC;

        public Triangle(double sideA,double sideB,double sideC)
            : base(sideA,sideB)
        {

            this.SideC = sideC;

        }


        public double SideC 
        {
            get
            {
                return this.sideC;
            }
            set
            {

                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("SideC","Incorrect");    
                }

                this.sideC = value;
            }
        }


        public override double CalculateArea()
        {
            double areaResult;
            double halfPerimeter;
            halfPerimeter = this.CalculatePerimeter() / 2;

            double areaSquaredResult;
            areaSquaredResult = halfPerimeter;

            areaSquaredResult = areaSquaredResult * halfPerimeter - this.Width;
            areaSquaredResult = areaSquaredResult * halfPerimeter - this.Height;
            areaSquaredResult = areaSquaredResult * halfPerimeter - this.SideC;

            areaResult = Math.Sqrt(areaSquaredResult);
            return areaResult;
        }

        public override double CalculatePerimeter()
        {
            double resultPerimeter;
            resultPerimeter = this.Width + this.Height + this.SideC;
            return resultPerimeter;

        }

    }
}
