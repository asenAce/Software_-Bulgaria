using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  

namespace CircularLinkedList
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, x;

            
            CircularLinkedList List = new CircularLinkedList();

            List.CreateList();

            while (true)
            {
                Console.WriteLine("1. Display List.");
                Console.WriteLine("2. Insert in a empty List");
                Console.WriteLine("3. Insert in the beginning of the List.");
                Console.WriteLine("4. Insert at the end of the list.");
                Console.WriteLine("5. Insert after a Node.");
                Console.WriteLine("6. Delete first Node.");
                Console.WriteLine("7. Delete last Node.");
                Console.WriteLine("8. Delete any Node.");
                Console.WriteLine("9. Quit.");

                Console.WriteLine("Please neter your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                //Validation
                if (choice == 9)
                {
                    Console.WriteLine("Program terminated.");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        List.DisplayList();
                        break;
                    case 2:
                        Console.WriteLine("Please enter the element to be inserted: ");
                        try
                        {
                            data = Convert.ToInt32(Console.ReadLine());
                            List.InsertInEmptyList(data);
                            break;
                        }
                        catch (Exception anException)
                        {
                            Console.WriteLine(anException.Message);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        List.InsertInBeginning(data);
                        break;
                    case 4:
                        Console.WriteLine("Please enter the element to be inserted");
                        try
                        {
                            data = Convert.ToInt32(Console.ReadLine());
                            List.InsertAtEnd(data);
                            break;
                        }
                        catch (Exception anException)
                        {
                            Console.WriteLine(anException.Message);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Please enter the element to be inserted");
                        try
                        {
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter the element after which you wish to be inserted:");
                            try
                            {
                                x = Convert.ToInt32(Console.ReadLine());
                                List.InsertAfter(data,x);
                            }
                            catch (Exception anException)
                            {
                                Console.WriteLine(anException.Message );
                            }
                        }
                        catch (Exception anException)
                        {
                            Console.WriteLine(anException.Message);
                        }
                        
                        break;
                    case 6:
                        List.DeleteFirstNode();
                        break;
                    case 7:
                        List.DeleteLastNode();
                        break;
                    case 8:
                        Console.WriteLine("Which Note");
                        try
                        {
                            data = Convert.ToInt32(Console.ReadLine());
                            List.DeleteNode(data);
                            break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Program is Terminated");
        }
    }
}
