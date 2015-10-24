using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LightTheTorches_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] basement = new char[n];

            string currentState = Console.ReadLine();

            int strIndex = 0;
            for (int i = 0; i < basement.Length; i++)
            {
                if (strIndex >= currentState.Length)
                {
                    strIndex = 0;
                }

                basement[i] = currentState[strIndex];
                strIndex++;
            }

            int currentPosition = basement.Length / 2;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] command = input.Split(' ');
                string direction = command[0];
                int roomsToPass = int.Parse(command[1]);

                int newPosition;
                switch (direction)
                {
                    case "LEFT":
                        newPosition = currentPosition - (roomsToPass + 1);
                        newPosition = newPosition >= 0 ? newPosition : 0;
                        if (newPosition == currentPosition)
                        {
                            break;
                        }
                        else
                        {
                            currentPosition = newPosition;
                        }
                        
                        basement = UpdateChar(currentPosition, basement);
                        break;

                    case "RIGHT":
                        newPosition = currentPosition + (roomsToPass + 1);
                        newPosition = newPosition < basement.Length ? newPosition : basement.Length - 1;
                        if (currentPosition == newPosition)
                        {
                            break;
                        }
                        else
                        {
                            currentPosition = newPosition;
                        }

                        basement = UpdateChar(currentPosition, basement);
                        break;

                    default:
                        break;     
                }
            }

            int darkRoomsCount = 0;
            for (int i = 0; i < basement.Length; i++)
            {
                if (basement[i] == 'D')
                {
                    darkRoomsCount++;
                }
            }

            int totalPrays = darkRoomsCount * 'D';

            Console.WriteLine(totalPrays);
        }

        private static char[] UpdateChar(int position, char[] array)
        {
            if (array[position] == 'L')
            {
                array[position] = 'D';
            }
            else
            {
                array[position] = 'L';
            }

            return array;
        }
    }
}
