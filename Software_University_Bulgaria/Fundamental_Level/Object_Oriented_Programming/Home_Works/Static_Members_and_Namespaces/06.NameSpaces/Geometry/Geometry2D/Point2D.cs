﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NameSpaces.Geometry.Geometry2D
{
    class Point2D
    {

        private double xCoordinate;
        private double yCoordinate;

        public Point2D(double xCoordinate = 0, double yCoordinate = 0)
        {
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;

        }

        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }

    }
}
