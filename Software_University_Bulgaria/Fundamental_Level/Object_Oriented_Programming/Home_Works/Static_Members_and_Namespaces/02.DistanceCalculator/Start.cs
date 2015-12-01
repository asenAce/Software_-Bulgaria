using _01.Point3DTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DistanceCalculator
{
    class Start
    {
        static void Main(string[] args)
        {
            //Creating objects aPoint , bPoint from class Point3D passing atributes(value,value,value)
            Point3D aPoint = new Point3D(-7,-4,3);
            Point3D bPoint = new Point3D(17,6,2.5);

            // Write on the console from class DistanceCalculator call . dot separetor the method CalculateDistance passing the atributes;
            Console.WriteLine(DistanceCalculator.CalculateDistance(aPoint,bPoint));

        }
    }
}
