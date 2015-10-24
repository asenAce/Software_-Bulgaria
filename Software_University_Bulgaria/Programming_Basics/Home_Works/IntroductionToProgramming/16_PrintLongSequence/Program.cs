using System;


namespace PrintLongSequence
{
    class Program
    {
        static void Main()
        {
            int multiplier = 1;
            Console.WriteLine("The first 1000 numbers of a sequence are");      // I am using printASequence as a basse , work clever more than hard is my motto ;-) 
            for (int i = 2; i <= 1001; i++)                                     // Here i am using the for loop !!
            {
                Console.Write(i * multiplier + ", ");
                multiplier = multiplier * -1;               // this line of code makes the number negative as alternate one time positive one time negative number!!
            }
            Console.Read();
        }
    }

}
