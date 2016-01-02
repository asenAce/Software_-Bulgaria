using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;
using System.Speech.Synthesis;
using System.IO;

namespace Grades
{
    class Program
    {

        static void GiveBookAName(GradeBook book)
        {
            book.Name = "The Gradebook";
        }

        static void IncrementNumber(int number)
        {
            number += 1;
        }

        static void Main(string[] args)
        {

            IGradeTracker  Book = CreateGradeBook();
            GradeTracker book = CreateGradeBook();


           SpeechSynthesizer synth = new SpeechSynthesizer();
           synth.Speak("kola ");

            Arrays();   // instantiate an Array


            string name1 = "Scott";
            string name2 = "scott";

            bool areEqual = name1.Equals(name2,StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(areEqual);

            Immutable();
            PassByValue();

          //  GradeBook book = new GradeBook(); //Construction of an Object
            GradeBook book = CreateGradeBook();
            
            //   Console.WriteLine(x2);
            FileStream stream = null;
            StreamReader reader = null;

            book.DoSomething();
            book.WriteGrades(Console.Out);

            try
            {
                 stream = File.Open("grades.txt",FileMode.Open);
                 reader = new StreamReader(stream);


                string line = reader.ReadLine();    

                    //   string[] lines = File.ReadAllLines("grades.txt");
                while (line != null)
                {
                    float grade = float.Parse(line);
                    book.AddGrade(grade);
                    line = reader.ReadLine();
                }
                reader.Close();
                stream.Close();

            /**
                foreach (string line in lines)
                {
                    float grade = float.Parse(line);
                    book.AddGrade(grade);
                }
                **/

            }

            catch (FileLoadException ex)
            {
                
                Console.WriteLine("Could not locate the file. grades.txt");
            }

            catch  (UnauthorizedAccessException ex)
            {
                Console.WriteLine("No access!");
                return;
            }

            
              
            finally     
            {
                if (reader != null)
            	{
		            reader.Close();
	            }
                if (stream != null)
                {
                    stream.Close();
                }
            }

            

            /**
            book.AddGrade(91);
            book.AddGrade(85.5f);
            book.AddGrade(75F);
            book.WriteGrades(Console.Out);
            **/

            #region Output
            GradeStatistics stats = book.ComputeStatistics();

            try
            {
               // Console.WriteLine("Name for the book?");
                // book.Name = Console.ReadLine();
            }
            catch (ArgumentException )
            {

                Console.WriteLine("Invalid name!");
            }

            

            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged;
            book.NameChanged -= OnNameChanged;
           // book.NameChanged = new NamedChangedDelegate(OnNameChanged);
            book.Name = "Alen Books";
            WriteNames(book.Name);  // Declaring the variables for the Array "","",""

            /**
            int number = 20;
            WriteBytes(number);
            WriteBytes(stats.AverageGrade);
            **/

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine("{0}  {1}",stats.LetterGrade,stats.Description);
 
            #endregion Output
            /**
            GradeBook book2 = new GradeBook();
            book.AddGrade(75);
            **/
        }

        private static IGradeTracker CreateGradeBook()
        {
            GradeTracker book = new ThrowAwayGradeBook();
            return book;
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            throw new NotImplementedException("*****");
        }

        
        private static void OnNameChanged2(string oldValue,string newValue)
        {
            //This Function will be executed when somebody change the name of the Gradebook

            Console.WriteLine("Name changed from  {0}  to  {1}",oldValue,newValue);
        }
        

        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);

        }

        private static void WriteByteArray(byte[] bytes)
        {
            foreach (byte b in bytes)
            {
                Console.Write("0x{0:X}", b);
            }
            Console.WriteLine();
        }
        
        private static void WriteNames(params string [] names) // params meen an arrays of string types.
        {   // This is the Function WriteNames
            foreach (string  name in names)
            {
                Console.WriteLine(name);
            }

        }



        private static void Arrays()
        // function Arrays
        {
            float[] grades;             // creating an Array type float type ID grades
            grades = new float[3];      // Array grades hold 4 elements [4]

            AddGrades(grades);

            foreach (float grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private static void AddGrades(float[] grades)  // A function that take an Array
        {
            if (grades.Length >= 3)
            {
                grades[0] = 91f;        // Assigning the values to the possitions in the Array [0]..[1]
                grades[1] = 89.1f;
                grades[2] = 75f;
            }
            
        }

        private static void Immutable()
        {
            string name=" Scott";
            name = name.Trim();
            Console.WriteLine(name);

            DateTime date = new DateTime(2014,1,1);
            date.AddHours(25);

            Console.WriteLine(date);
        }

        private static void PassByValue()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(g2);
            Console.WriteLine(g1.Name);
            /**
            g1 = new GradeBook();
            
            g1.Name = "Scott's book";
            
            */
            int x1 = 4;
            IncrementNumber(x1);
            Console.WriteLine(x1);
        }
    }
}
