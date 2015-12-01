using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using _01.Point3DTest;

namespace _03.Path3D
{
    static class Storage
    {

        private const string PATH_MATCHER = @"Path:\s+((?:Point\s*\((?:.*?),\s*(?:.*?),\s*(?:.*?)\)\s*)+)";
        private const string POINT_MATCHER = @"Point\s*\((.*?),\s*(.*?),\s*(.*?)\)";

        public static void SavePathToFile(String fileLocation,Path3D path)
        {
            File.WriteAllText(fileLocation,path.ToString());
        }

        /*
         * <summery>
         * Searches for the first occurence of a Path string in the source file and returns a Path3D object.
         * <summery>
         * <param name = "fileLocation "> The path to the file being read.</param>
         * <returns> A Path3D object</returns>
         * */

        public static Path3D LoadPathFromFile(String fileLocation)
        {

            string input = File.ReadAllText(fileLocation);

            if (!Regex.IsMatch(input,PATH_MATCHER))
            {
                throw new ArgumentNullException("input","File does not contain Path3D data.");
            }

            string pathAsString = Regex.Match(input, PATH_MATCHER).Groups[1].Value;

            var pointsInPath = new List<Point3D>();

            foreach (Match match in Regex.Matches(pathAsString,POINT_MATCHER))
            {

                double xCoordinate = double.Parse(match.Groups[1].Value);
                double yCoordinate = double.Parse(match.Groups[2].Value);
                double zCoordinate = double.Parse(match.Groups[3].Value);

                pointsInPath.Add(new Point3D(xCoordinate,yCoordinate,zCoordinate));
            }
            Path3D pathFromFile = new Path3D(pointsInPath);


            return pathFromFile;

        }

    }
}
