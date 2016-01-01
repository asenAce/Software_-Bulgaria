using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "SoftUni";
            Console.WriteLine(str);

            for (int i = 0; i < str.Length;i++ )
            {
                Console.WriteLine("str[{0}] = {1}",i,str[i]);
            }

            Console.WriteLine(str.IndexOf("Uni"));
            Console.WriteLine(str.IndexOf("uni"));

            Console.WriteLine(str.Substring(4,3));
            Console.WriteLine(str.Replace("Soft" , "Hard"));
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());


            string firstName = "Steve ";
            string lastName = "Jobs";

            int age = 56;
            Console.WriteLine(firstName + " " + lastName + "(age: " + age +")");

            string allLangs = "HTML5,Java,C#";
            string[] langs = allLangs.Split(new char[] {',',';',' '},StringSplitOptions.RemoveEmptyEntries);

            foreach ( var lang in langs)
            {
                Console.WriteLine(lang);
                Console.WriteLine("Langs = " + string.Join(",", langs));
                Console.WriteLine(" \n\n Software University ".Trim());
            }
        }
    }
}
