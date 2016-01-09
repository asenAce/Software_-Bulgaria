using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7 + 9;
            Console.WriteLine(a);       //16

            string firstName = "Asen";
            string lastName = "Lozanov";

            string fullName = firstName + "  " + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine(firstName + " " + lastName);
            Console.Read();

            // Operators

            int squarePerimeter = 17;
            double squareSide = squarePerimeter / 4.0;
            double squareArea = squareSide * squareSide;
            Console.WriteLine(squareSide);
            Console.WriteLine(squareArea);
            Console.Read();

            int c = 5;
            int d = 4;

            Console.WriteLine(c + d);   //9
            Console.WriteLine(c + d++); //9
            Console.WriteLine(c + d);   //10
            Console.WriteLine(c + (++d));    //11
            Console.WriteLine(c + d);       //11
            Console.WriteLine(14 / c);      //2
            Console.WriteLine(14 % a);      //4

            int one = 1;
            int two = 0;
            // Console.WriteLine(one / two);  = DivideByZeroException

            double dMinusOne = -1.0;
            double dZero = 0.0;
            Console.WriteLine(dMinusOne / dZero); // This will give us - Infinity

            // Logic operators

            bool e = true;
            bool f = false;
            Console.WriteLine(e && f);      // = false
            Console.WriteLine(e || f);      // = True
            Console.WriteLine(!f);      // = True
            Console.WriteLine( e || true); // True
            Console.WriteLine((5> 7)^ (e == f));    //false
            Console.Read();

            string csharp = "C#";
            string dotnet = ".NET";
            string csharpDotNet = csharp + dotnet;
            Console.WriteLine(csharpDotNet);        //C#.NET
            string csharpDotNet4 = csharpDotNet + "  " + 4;
            Console.WriteLine(csharpDotNet4);   // C# .NET

            int q = 10, w = 5;
            Console.WriteLine("q > w : " + (q > w));  //True
            Console.WriteLine("x < y : " + (q< w ));    //False
            Console.WriteLine("x >= y : " + (q >= w));  // True
            Console.WriteLine("x <= y : " +(q <= w));   //False
            Console.WriteLine("x == y : " + (q == w));  //false
            Console.WriteLine("q != w : " + (q != w));

            int r = 2;
            int t = 4;

            r *= t;  //Same as r = r * t;
            Console.WriteLine(r);       //8

            int y = 6;
            int u = 4;
            Console.WriteLine(y> u ? "y>u" : "y<= u");      // a>b
            int num = y == u ? 1 : -1;      // num will have value -1

            // where " . " operator call the method 

            Console.WriteLine(DateTime.Now);    // Prints the date + time , .Now is a method of the class DateTime

            int[] arr = { 1,2,3};
            Console.WriteLine(arr[0]);    // print number 1 because is on possition 0...
            string str = "Haluuu";          // 0 = H , 1 = a , 2 = l possition
            Console.WriteLine(str[1]);     //print a a char because is on possition 1..

            int? i = 5;
            Console.WriteLine(i ?? -1); // 5
            string name = null;
            Console.WriteLine(name ?? "(no name) ");  // (no name

            int o = 6;
            int p = 3;

            Console.WriteLine(o + p / 2);   //7
            Console.WriteLine((o + p ) / 2);    // 4

            string s = " a beer";
            Console.WriteLine(s is string);     // True
            string notNullString = s;
            string nullString = null;
            Console.WriteLine(nullString ?? "Unspecified");        // Unspecified
            Console.WriteLine(notNullString ?? "Specified");   //Specified

            // Convert implicit

            int myInt = 5;
            Console.WriteLine(myInt);   //5

            //long myLong = myInt;
            //Console.WriteLine(myLong);  //5
            //Console.WriteLine(myLong + myInt);  //10

            double myDouble = 5.1d;
            Console.WriteLine(myDouble);        // 5.1
            long myLong = (long)myDouble;
            Console.WriteLine(myLong);  //5

            myDouble = 5e9d; // 5*10^9
            Console.WriteLine(myDouble);    //50000000
          //  int   myInt = (int)myDouble;

            Console.WriteLine(myInt);       //-2147483648
            Console.WriteLine(int.MaxValue);    //-2147483648






        }
    }
}
