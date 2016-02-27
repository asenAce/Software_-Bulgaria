using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLinkedList
{
    class Demo
    {
        static void Main(string[] args)
        {

            int choice, data;

            SortedLinkedList List = new SortedLinkedList();
            List.Create();

            while (true)
            {

                Console.WriteLine(" 1.Display the List.");
                Console.WriteLine(" 2.Insert a new Node.");
                Console.WriteLine(" 3.Search.");
                Console.WriteLine(" 4.Exit.");
                Console.WriteLine("Please enter your Choice: ");

                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 4)
                    {
                        break;
                    }
               
                switch (choice)
                {
                    case 1:
                        List.DisplayList();
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Please write the Node to be inserted:");
                            data = Convert.ToInt32(Console.ReadLine());
                            List.InsertInOrder(data);
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                        }
                        
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Please write which Node to be Search? ");
                            data = Convert.ToInt32(Console.ReadLine());
                            List.Search(data);
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                        }
                        
                        break;
                    case 4:
                        Console.WriteLine("The program is terminated: ");
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }

        }
    }
}
