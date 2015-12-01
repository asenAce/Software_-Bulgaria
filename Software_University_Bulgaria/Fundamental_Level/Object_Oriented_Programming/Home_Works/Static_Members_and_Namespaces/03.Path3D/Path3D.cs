
using _01.Point3DTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Path3D
{
    class Path3D
    {

        //Generic List<>
        private List<Point3D> path = new List<Point3D>();

        public Path3D(List<Point3D> path = null)
        {

        }

        public  List<Point3D> Path 
        { 
            get
            {
                return this.path;
            }
            set
            {
                this.path = value ?? new List<Point3D>();
            }
        }

        // a Method which does not return anything type void
        public void AddPointToPath(Point3D point)
        {
            var currentPath = this.Path;

            currentPath.Add(point);
            this.Path = currentPath;
        }

        public override string ToString()
        {

            string result = "Path: \r \n";

            foreach (var point in this.Path)
            {
                result = result + "\t" + point.ToString()+ "\r\n";
            }

            return result;
        }


    }
}
