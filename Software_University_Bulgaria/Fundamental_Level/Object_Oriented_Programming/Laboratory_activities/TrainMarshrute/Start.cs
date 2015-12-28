using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using InPutOutPut.Possition;
using System.Threading;

namespace InPutOutPut
{
    class Start
    {
        static void Main(string[] args)
        {
            double sleepTime = 100;

            Queue<Possition> trainMarshrute = new Queue<Possition>();

            Random randomGenerator = new Random();

            Possition[] trainMoveDirections = new Possition[]
            {
                new Possition(1,0),
                new Possition(0,1),
                new Possition(-1,0),
                new Possition(0,-1),
            };

            int currentDirection = 0;

            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight;

            Possition trainStops = new Possition(randomGenerator.Next(1,Console.WindowWidth - 1)
                ,randomGenerator.Next(1,Console.WindowHeight - 1));

            for (int i = 0; i <= 6 ; i++)
            {
                trainMarshrute.Enqueue(new Possition(i,0));
            }

            foreach (var item in trainMarshrute)
            {
                Console.SetCursorPosition(item.X,item.Y);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("#");
            }

            Possition locomotive = trainMarshrute.Last();
            Console.SetCursorPosition(locomotive.X,locomotive.Y);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("@");

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();

                    if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (currentDirection != 2)
                        {
                            currentDirection = 0;
                        }
                    }

                    if (pressedKey.Key == ConsoleKey.DownArrow)
                    {
                        if (currentDirection != 3)
                        {
                            currentDirection = 1;
                        }
                    }

                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (currentDirection != 0)
                        {
                            currentDirection = 2;
                        }
                    }

                    if (pressedKey.Key == ConsoleKey.UpArrow)
                    {
                        if (currentDirection != 1)
                        {
                            currentDirection = 3;
                        }
                    }
                }

                // the Train stops;

                Console.SetCursorPosition(trainStops.X,trainStops.Y);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("S");

                //Previous possition of the locomotive;
                Possition previousLocomotive = trainMarshrute.Last();

                //New Locomotive possiton;
                Possition newLocomotivePossition = new Possition(
                    previousLocomotive.X + trainMoveDirections[currentDirection].X
                    ,previousLocomotive.Y + trainMoveDirections[currentDirection].Y);

                //Check constrains

                if (newLocomotivePossition.X >= Console.WindowWidth || 
                    newLocomotivePossition.X < 0 ||
                    newLocomotivePossition.Y >= Console.WindowHeight ||
                    newLocomotivePossition.Y < 0 ||
                    trainMarshrute.Contains(newLocomotivePossition))
                {
                    //End Game
                    Console.SetCursorPosition(0,0);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Game Over Your Points : {0}",trainMarshrute.Count);
                    return;
                }

                //new Locomotive for the train;

                Console.SetCursorPosition(previousLocomotive.X,previousLocomotive.Y);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("*");

                //Add new wagons to the train and display them on the screen.
                trainMarshrute.Enqueue(newLocomotivePossition);
                Console.SetCursorPosition(newLocomotivePossition.X,newLocomotivePossition.Y);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("&");

                //Check if the Train is on a trainStop;
                if (newLocomotivePossition.X == trainStops.X && newLocomotivePossition.Y == trainStops.Y)
                {
                    //Atached a new wagone to the Train station:
                    trainStops = new Possition(
                        randomGenerator.Next(1, Console.WindowWidth - 1)
                        ,randomGenerator.Next(1,Console.WindowHeight - 1));

                    Console.SetCursorPosition(trainStops.X,trainStops.Y);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("+");
                }

                    //Remove the last wagon 
                else
                {
                    Possition aPossition = trainMarshrute.Dequeue();
                    Console.SetCursorPosition(aPossition.X,aPossition.Y);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(" ");
                }

                //slow the train
                Thread.Sleep((int) sleepTime);

                //Change the speed;
                sleepTime -= 0.05;
            }

        }
    }
}
