using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int centerX = int.Parse(Console.ReadLine());
            int centerY = int.Parse(Console.ReadLine());
            int countryRadius = int.Parse(Console.ReadLine());

            int detectedPlanes = int.Parse(Console.ReadLine());
            for (int plane = 0; plane < detectedPlanes; plane++)
            {
                int planeX = int.Parse(Console.ReadLine());
                int planeY = int.Parse(Console.ReadLine());

                int planeDistanceX = planeX - centerX;
                int planeDistanceY = planeY - centerY;

                double distanceToPlane = Math.Sqrt((planeDistanceX * planeDistanceX) + (planeDistanceY * planeDistanceY));

                if (countryRadius >= distanceToPlane)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", planeX, planeY);
                }
            }
        }
    }
}
