using _01.Point3DTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.DistanceCalculator 
{
    public static class DistanceCalculator 
    {

        //Create a Method , () taking those parameters 
        public static double CalculateDistance(Point3D pointA,Point3D pointB  ) 
        {
            //Calcolate the variables:
            double deltaX = pointA.XCoordinate - pointB.XCoordinate;
            double deltaY = pointA.YCoordinate - pointB.YCoordinate;
            double deltaZ = pointA.ZCoordinate - pointB.ZCoordinate;

            // the Formula;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

            //return the result
            return distance;


        }



    }
}
