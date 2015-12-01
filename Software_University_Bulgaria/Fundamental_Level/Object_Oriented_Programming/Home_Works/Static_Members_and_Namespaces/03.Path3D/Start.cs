﻿using _01.Point3DTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Path3D
{
    class Start
    {
        static void Main(string[] args)
        {

            List<Point3D> listOfPoints = new List<Point3D>();
            listOfPoints.Add(Point3D.StartingPoint);

            listOfPoints.Add(new Point3D(0,1,2));
            listOfPoints.Add(new Point3D(1.5,-3.4));
            listOfPoints.Add(new Point3D(-3.1,0,4));

            Path3D path = new Path3D(listOfPoints);
            path.AddPointToPath(new Point3D(0,-1,1.111111));
            Console.WriteLine(path);


            string fileLocation = "Path3D.txt";
            Storage.SavePathToFile(fileLocation,path);

            Path3D pathFromFile = Storage.LoadPathFromFile(fileLocation);
            Console.WriteLine(pathFromFile);

        }
    }
}
