using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NameSpaces.Geometry.Geometry2D
{
     static  class DistanceCalculator2D
    {

         public static double CalculateDistance2D(Point2D pointA,Point2D pointB)
         {

             double delatX = pointA.XCoordinate - pointB.XCoordinate;
             double deltaY = pointA.YCoordinate - pointB.YCoordinate;

             double distance = Math.Sqrt(delatX * delatX + deltaY * deltaY);

             return distance;

         }


    }
}
