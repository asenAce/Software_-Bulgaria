using _01.Shapes.IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes.Shapes
{
     abstract  class BasicShape : IShapes
    {
         private double width;
         private double height;

         public BasicShape(double width, double height)
         {
             this.Width = width;
             this.Height = height;
         }

         public double Width 
         {
             get
             {
                 return this.width;
             }
             set
             {
                 if (value <= 0)
                 {
                     throw new ArgumentOutOfRangeException("width","Incorrect");
                 }

                 this.width = value;

             }
         }

         public double Height 
         {
             get
             {
                 return this.height;
             }
             set
             {
                 if (value <= 0)
                 {
                     throw new ArgumentOutOfRangeException("height","Incorrect");
                 }

                 this.height = value;
             }
         }

         public abstract double CalculateArea();
         public abstract double CalculatePerimeter();



    }
}
