using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NameSpaces.Geometry.Geometry2D
{
    class Circle : Figure2D
    {
        private double radius;

        public Circle(Point2D center,double radius = 0)
        {

        }

        public Point2D Center { get; set; }


        public double Radius 
        { 
            get
            {
                return this.radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("radius","Radius can not be a negative number!");    
                }

                this.radius = value;
            }
        }




    }
}
