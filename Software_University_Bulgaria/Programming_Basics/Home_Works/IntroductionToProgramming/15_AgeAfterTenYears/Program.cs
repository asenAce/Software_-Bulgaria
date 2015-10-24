using System;



    class AgeAfterTenYears
    {
        static void Main()
        {
            string date = Console.ReadLine();

            DateTime myBirthday = DateTime.Parse(date);             //DateTime is a method in a library,Parse convert the sting in a data int;

            int age = 0;                                            // Start from 0;

            if (myBirthday.Date.Month <= DateTime.Now.Date.Month)   //The (condition) if statement 
            {
                age = DateTime.Now.Year - myBirthday.Year;           // I am writing the formula to calculate my current age!
            }
            else
            {
                age = DateTime.Now.Year - myBirthday.Year - 1;
            }
            Console.WriteLine("You are {0} years old.",age);
            Console.WriteLine("After 10 years you will be {0} years old.",(age + 10));
            Console.ReadLine();                                       // This line of code hold the console so we can see !!
        }
    }

