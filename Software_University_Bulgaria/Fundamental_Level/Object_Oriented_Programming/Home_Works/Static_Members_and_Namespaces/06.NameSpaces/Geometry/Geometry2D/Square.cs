
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NameSpaces.Geometry.Geometry2D
{
    class Square : Figure2D
    {

        private Point2D location;
        private double sideLength;
        double area;

        public Square(Point2D location, double sideLength = 0)
        {

        }

        public Point2D Location { get; set; }

        public double SideLength 
        {
            get
            {
                return this.SideLength;
            }
            set
            {

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("sideLength", "Incorrect");
                }

                this.sideLength = value;
            }
        }

        public double Area
        {
            
            get 
            {
                double area = this.sideLength * this.SideLength;
                return area;
            }
        }





    }
}
