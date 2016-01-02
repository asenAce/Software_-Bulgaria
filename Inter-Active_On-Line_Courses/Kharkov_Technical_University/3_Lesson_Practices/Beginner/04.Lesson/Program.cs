using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 1234.56m;
            string concatenated = "$" + price;
            string formatted = string.Format("{0:C}",price);
            //      string interpolated = $"{price : C }";

            //Add "using System.Globalization;"
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
            NumberFormatInfo format = culture.NumberFormat;

            string customFormatted = price.ToString("C",format);
             
            /***
             * We can change the number format by setting
             * its properties.
             * */

            format.CurrencyGroupSeparator = "  ";
            string withSpace = price.ToString("C",format);
        
        }
    }
}
