using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeData
{
    class Demo
    {
        static void Main(string[] args)
        {


            int choice, data, k, x;


            SingleLinkedList aList = new SingleLinkedList();

            aList.Create();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(" Select the Following >>>>");
                Console.WriteLine();
                Console.WriteLine(" press #1 for Display the List. ");
                Console.WriteLine(" press #2 for Count the List.");
                Console.WriteLine(" press #3 for Search of an element.");
                Console.WriteLine(" press #4 for insert in the empty list/Insert in the beginning of the list. ");
                Console.WriteLine(" press #5 for insert a Node at the end of the list. ");
                Console.WriteLine(" press #6 for Insert a Node after a specified Node. ");
                Console.WriteLine(" press #7 for Insert a Node before a specified Node. ");
                Console.WriteLine(" press #8 for Insert a Node at given position. ");
                Console.WriteLine(" press #9 For Deletion first Node. ");
                Console.WriteLine(" press #10 For Delete last Node. ");
                Console.WriteLine(" press #11 For Delete any Node. ");
                Console.WriteLine(" press #12 For Reverse the List. ");
                Console.WriteLine(" press #13 for Bubble Sort by exchanging data. ");
                Console.WriteLine(" press #14 for Bubble sort by exchanging links. ");
                Console.WriteLine(" press #15 for MergeSort. ");
                Console.WriteLine(" press #16 for Insert Cycle. ");
                Console.WriteLine(" press #17 for Detect Cycle. ");
                Console.WriteLine(" press #18 for Remove Cycle. ");
                Console.WriteLine(" press #19 for Exiting. ");
                Console.WriteLine();

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                {
                    Console.WriteLine("Good Bye");
                    break;
                }

                switch (choice)
                {

                    case 1:
                        aList.Display();
                        break;
                    case 2:
                        aList.Count();
                        break;
                    case 3:
                        Console.WriteLine("Please write down the element to be Searched!");
                        data = Convert.ToInt32(Console.ReadLine());

                        aList.Search(data);
                        break;
                    case 4:
                        Console.WriteLine("Please write down the value of the Node wish to be inserted in the beginning of the Node.");
                        data = Convert.ToInt32(Console.ReadLine());
                        aList.InsertAtTheBeginning(data);
                        break;
                    case 5:
                        Console.WriteLine("Please write down the Node to be Inserted at the end of the List.");
                        data = Convert.ToInt32(Console.ReadLine());
                        aList.InsertAtTheEnd(data);
                        break;
                    case 6:
                        Console.WriteLine("Please enter the element to be inserted.");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("After which element to be inserted...");
                        x = Convert.ToInt32(Console.ReadLine());
                        aList.InsertAtSpecifiedAfterNode(data,x);
                        break;
                    case 7:
                        Console.WriteLine("Please Specified the Node to be inserted before.");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The element before to be inserted...");
                        x = Convert.ToInt32(Console.ReadLine());
                        aList.InsertAtSpecifiedBeforeNode(data,x);
                        break;
                    case 8:
                        Console.WriteLine("Please write the Node to be Inserted at given position:");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The position");
                        x = Convert.ToInt32(Console.ReadLine());
                        aList.InsertAtSpecifiedPosition(data,x);
                        break;
                    case 9:
                        aList.DeleteFirstNode();
                        break;
                    case 10:
                        aList.DeleteLastNode();
                        break;
                    case 11:
                        Console.WriteLine("The Element to be delited: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        aList.DeleteAnyNode(data);
                        break;
                    case 12:
                        aList.Reverse();
                        break;
                    case 13:
                        aList.BubbleSortByExchengingData();
                        break;
                    case 14:
                        aList.BubbleSortByExchengingLinks();
                        break;
                    case 15:
                        aList.MergeSort();
                        break;
                    case 16:
                        Console.WriteLine("Please enter the element at which the cycle has to be inserted:  ");
                        data = Convert.ToInt32(Console.ReadLine());
                        aList.InsertCycle(data);
                        break;
                    case 17:
                        aList.DetectCycle();
                        break;
                    case 18:
                        aList.RemoveCycle();
                        break;
                    case 19:
                        Console.WriteLine("Good Bye");
                        break;
                    default:
                        Console.WriteLine("Incorect ");
                        break;
                }


                // Part II Merge LinkedLists 

                SingleLinkedList listOne = new SingleLinkedList();
                SingleLinkedList listTwo = new SingleLinkedList();

                listOne.Create();
                listTwo.Create();

                listOne.BubbleSortByExchengingData();
                listOne.BubbleSortByExchengingLinks();

                Console.WriteLine();
                Console.WriteLine("Please write the first list >>");
                listOne.Display();

                Console.WriteLine();
                Console.WriteLine("Please write the Second List >> ");
                listTwo.Display();

                SingleLinkedList listThree;

                listThree = listOne.MergeOne(listTwo);
                Console.WriteLine("The Merge list is >> ");
                listThree.Display();

                Console.WriteLine("The First List >>");
                listOne.Display();

                Console.WriteLine("The Second List >>");
                listTwo.Display();

                // Error do not recognice the MergeTwo() Method ??
                listThree = listOne.MergeTwo(listTwo);
                Console.WriteLine("The Merge list is >> ");
                listThree.Display();

                Console.WriteLine("The First List >>");
                listOne.Display();

                Console.WriteLine("The Second List >>");
                listTwo.Display();

                Console.WriteLine();
            }

            Console.WriteLine("Exit >> ");

        }
    }
}
