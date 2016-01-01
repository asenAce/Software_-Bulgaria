﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculation
{
    class Program
    {
        static void Main(string[] args)
        {

            //Get value to calculate
            double double1 = GetValue("Enter value 1: ");
            double double2 = GetValue("Enter value 2: ");

            double result = 0;

            //Do math operation
            while (true)
            {
                Console.WriteLine("(A)dd  (S)ubtraction  (M)ultiply  (D)ivide:  ");
                ConsoleKeyInfo info = Console.ReadKey();
                string operation = info.Key.ToString();

                switch (operation.ToUpper())
                {
                    case "A" :
                        result = Add(double1,double2);
                        break;
                    case "S" :
                        result = Subtract(double1, double2);
                            break;
                    case"M":
                        result = Multiply(double1,double2);
                        break;
                    case"D":
                        result=Divide(double1,double2);
                        break;
                    default:
                        Console.WriteLine("Choose from supported operations");
                        continue;
                }
                Console.WriteLine("\nResult:  " + result);
                Console.Read();
                break;
            }
            
        }

        private static double GetValue(string label)
        {
            // the value to be returned
            double value;

            //Loop ubtil you get a valid entry

            while (true)
            {
                Console.Write(label);
                string input = Console.ReadLine();
                
                if (Double.TryParse(input,out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Value can not be parsed as a number ");
                }
            }

        }

        private static double Add(double double1,double double2)
        {
            return double1 + double2;
        }

        private static double Subtract(double double1, double double2)
        {
            return double1 - double2;
        }

        private static double Multiply(double double1, double double2)
        {
            return double1 * double2;
        }

        private static double Divide(double double1,double double2)
        {
            if (double1 == 0 || double2 == 0)
            {
                return 0;
            }
            else
            {
                return double1 / double2;
            }
        }

    }
}
