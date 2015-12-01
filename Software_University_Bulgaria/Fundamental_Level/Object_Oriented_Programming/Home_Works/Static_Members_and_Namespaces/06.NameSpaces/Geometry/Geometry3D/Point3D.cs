﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NameSpaces.Geometry.Geometry3D
{
    class Point3D
    {
        private double xCoordinate;
        private double yCoordinate;
        private double zCoordinate;


        public Point3D(double xCoordinate, double yCoordinate, double zCoordinate)
        {

            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
            this.ZCoordinate = zCoordinate;

        }

        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }
        public double ZCoordinate { get; set; }


    }
}
