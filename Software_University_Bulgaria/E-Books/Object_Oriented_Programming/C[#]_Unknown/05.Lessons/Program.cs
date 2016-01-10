using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Lesson
{
    // Switch case with enum:
    class Program
    {
        /*
         *  enum Major   {      ACCOUNTING = 1, CIS, ENGLISH, MATH, MARKETING   } 
         * */

        enum Major  //Declaring the enum 
        {
            ACCOUNTING = 1, CIS, ENGLISH, MATH, MARKETING // var. ACCOUNTING = values....
        }


        static void Main(string[] args)
        {

            /*
             * int major; 
             * Console.Write("Enter major code >> ");  
             * major = Convert.ToInt32(Console.ReadLine()); 
             * 
             * switch ((Major) major)     
             * {        
             * case Major.ACCOUNTING:       
             * case Major.CIS:        
             * case Major.MARKETING:         
             * Console.WriteLine("Major is in the Business Division");         
             * break;        
             * case Major.ENGLISH:        
             * case Major.MATH:          
             * Console.WriteLine("Major is in the Humanities Division");         
             * break;       
             * default:          
             * Console.WriteLine("Department number is invalid");       
             * break;
             * 
             * 
             * */

            int major; // Declaring the variable
            Console.WriteLine("Enter Major code >>");  // Promp the user
            major = Convert.ToInt32(Console.ReadLine());  // from right to left take the value from the Console. Convert it to int strore the value to = major () passing the parameters.

            //Logic Switch:
            switch ((Major) major) // condition
            {
                case Major.ACCOUNTING:
                case Major.CIS:
                case Major.ENGLISH:
                    Console.WriteLine("Major is in the Business Division"); 
                    break;
                case Major.MATH:
                case Major.MARKETING:
                    Console.WriteLine("Major is in the Humanities Division");
                    break;
                default:
                    Console.WriteLine("Department number is invalid"); 
                    break;
            }

        }
    }
}
