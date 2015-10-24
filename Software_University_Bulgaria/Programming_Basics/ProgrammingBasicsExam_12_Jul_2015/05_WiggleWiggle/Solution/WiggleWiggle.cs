using System;
using System.Linq;

class WiggleWiggle
{
    static void Main()
    {
        long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
        
        for (int i = 0; i < numbers.Length ; i+=2)
        {
            for (int j = 0; j < 63; j+=2)
            {
                //take current bits
                long mask = 1L << j;
        
                long currentUpperBit = numbers[i] & mask;
        
                long currentLowerBit = numbers[i + 1] & mask;
        
                //turn off current bits in the numbers
                numbers[i] &= ~mask;
                numbers[i + 1] &= ~mask;
        
                //applying the upper bit in the lower number and vice versa
                numbers[i] |= currentLowerBit;
                numbers[i + 1] |= currentUpperBit;
            }
        }
        
        //turning on all off bits and the other way around
        for (int i = 0; i < numbers.Length; i++)
        {
            long mask = long.MaxValue;
            numbers[i] ^= mask;
        }
        
        //printing the decimal representation first, than the binary.
        foreach (long number in numbers)
        {
            Console.WriteLine(number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(63,'0'));
        }
    }
}

