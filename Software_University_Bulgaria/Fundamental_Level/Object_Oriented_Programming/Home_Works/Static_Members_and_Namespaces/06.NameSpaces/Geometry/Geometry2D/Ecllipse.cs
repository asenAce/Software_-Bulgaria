using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NameSpaces.Geometry.Geometry2D
{
    class Ecllipse : Figure2D
    {

        private Point2D focusOne;
        private Point2D focusTwo;

        private double minorAxis;
        private double majorAxis;


        public Ecllipse(Point2D focusOne, Point2D focusTwo, double minorAxis = 0, double majorAxis = 0 )
        {

            this.FocusOne = focusOne;
            this.FocusTwo = focusTwo;
            this.MajorAxis = majorAxis;
            this.MinorAxis = minorAxis;

        }


        public Point2D FocusOne { get; set; }
        public Point2D FocusTwo { get; set; }

        public double MinorAxis 
        {
            get
            {
                return this.minorAxis;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("minorAxis","Incorrect");
                }

                this.minorAxis = value;
            }
        }


        public double MajorAxis 
        {
            get
            {
                return this.majorAxis;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("majorAxis","Incorrect");
                }

                this.majorAxis = value;
            }
        }





    }
}
