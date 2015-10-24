using System;


namespace printASequence
{
    class Program
    {
        static void Main()
        {
            int multiplier = 1;
            Console.WriteLine("The first 10 numbers of a sequence are");
            for (int i = 2; i <= 11; i++ )
            {
                Console.Write(i * multiplier +", ");
                multiplier = multiplier * -1;
            }
            Console.Read();
        }
    }

}
