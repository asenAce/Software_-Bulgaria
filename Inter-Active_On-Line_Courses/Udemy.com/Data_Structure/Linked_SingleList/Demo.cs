using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkLists
{
  public  class Demo
    {
        static void Main(string[] args)
        {
            //maybe is a good idea to declare my variables possitionX and ... here in the begining 
            int choice, data, k, x;

            SingleLinkedList aList = new SingleLinkedList();
            aList.CreateList(); 

            while (true)
            {
                Console.WriteLine("#1.For Display the list.");
                Console.WriteLine("#2.For Count the  number of the nodes.");
                Console.WriteLine("#3.For Search for an element.");
                Console.WriteLine("#4.For Insert in the empty list/Insert in the beginning of the ");
                Console.WriteLine("#5.For Insert a node at the end of the list.");
                Console.WriteLine("#6.For Insert a node after a specified node.");
                Console.WriteLine("#7.For Insert a node before a specified node.");
                Console.WriteLine("#8.For Insert a node at a given position.");
                Console.WriteLine("#9.For Delete first node.");
                Console.WriteLine("#10.For Delete last node.");
                Console.WriteLine("#11.For Delete any node.");
                Console.WriteLine("#12.For Reverse the list");
                Console.WriteLine("#13.For Bubble sort by exchanging data.");
                Console.WriteLine("#14.For Bubble sort by exchanging links.");
                Console.WriteLine("#15.For MergeSort.");
                Console.WriteLine("#16.For Insert Cycle.");
                Console.WriteLine("#17.For Detect Cycle.");
                Console.WriteLine("#18.For Remove cycle.");
                //Console.WriteLine("#20. Insert In a empty List. ");
                //Console.WriteLine("#21. InsertInTheBeginning.");
                Console.WriteLine("#19.For Quit.");

                // promp the user
                Console.WriteLine("Please enter you choice : ");
                // take the data
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        try
                        {
                            aList.DisplayTheList();
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                        }
                        break;
                    case 2:
                        try
                        {
                             aList.CountNodes();
                             break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                        }
                        continue;
                    case 3:
                        Console.WriteLine("Enter the element to be searched:");
                        try
                        {
                            Console.WriteLine("Enter the element to inserted >>");
                            data = Convert.ToInt32(Console.ReadLine());
                            aList.InsertInEmptyList(data);
                            break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                        }
                        continue;
                    case 4:
                        Console.WriteLine("Enter the element to be inserted: ");
                        try
                        {
                            Console.WriteLine("Enter the element to inserted >>");
                            data = Convert.ToInt32(Console.ReadLine());
                            aList.InsertInTheBeginning(data);
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                        }
                        break;
                        //!!
                    case 5:
                        Console.WriteLine("Please enter the element to be inserted:");
                        try
                        {

                            data = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please Enter the element  after which to insert: ");
                            x = Convert.ToInt32(Console.ReadLine());
                            aList.InsertAtTheEnd(data);
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine("incorrect!");
                        }
                        continue;
                    case 6:
                        Console.WriteLine("Please enter the element to be inserted: ");
                        try
                        {
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter the element before which to insert:  ");
                            x = Convert.ToInt32(Console.ReadLine());
                            aList.InsertAfter(data,x);
                            break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                        }
                        continue;
                    case 7:
                        Console.WriteLine("Please enter the element to be inserted: ");
                        try
                        {
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter the element before which to be inserted: ");
                            try
                            {
                                int elementX;
                                elementX = Convert.ToInt32(Console.ReadLine());

                                aList.InsertAfter(data,elementX);
                                break;
                            }
                            catch (Exception anExpected)
                            {
                                string theMessage;
                                theMessage = "Incorrect element,please try again:";

                                Console.WriteLine(theMessage);
                            }

                            break;
                        }
                            
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                        }
                        continue;
                    case 8:

                        Console.WriteLine("Please entered the element to be inserted: ");
                        try
                        {
                            data = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                Console.WriteLine("Please enter the possition at which would you like to insert: ");
                                int possitionX;
                                possitionX = Convert.ToInt32(Console.ReadLine());

                                aList.InsertAtPossition(data,possitionX);
                                break;
                            }
                            catch (Exception anExpected)
                            {
                              Console.WriteLine(anExpected.Message);
                            }
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                        }
                        continue;
                    case 9:
                        
                        try
                        {
                            aList.DeleteTheFirstNode();
                            break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                            break;
                        }

                        continue;
                    case 10:

                        try
                        {
                            aList.DeleteTheLastNode();
                            break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                        }

                        continue;
                    case 11:

                        Console.WriteLine("Please entered the element to be deleted: ");
                        try
                        {
                            data = Convert.ToInt32(Console.ReadLine());
                            aList.DeleteNode(data);
                            break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                            break;
                        }

                        continue;
                    case 12:

                        try
                        {
                            aList.ReverseList();
                            break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                            break;
                        }

                    case 13:

                        try
                        {
                            aList.BubbleSortExData();
                            break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                            break;
                        }

                        continue;
                    case 14:

                        try
                        {
                            aList.BubbleSortExLinks();
                            break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                            continue;  // continue || break ??
                        }

                    case 15:

                        try
                        {
                            aList.MergeSort();
                            break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                        }

                        continue;

                    case 16:

                        Console.WriteLine("Please enter the element at which the cycle has to be insereted: ");
                        try
                        {
                            data = Convert.ToInt32(Console.ReadLine());
                            aList.InsertCycle(data);
                            break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                            break;
                        }

                    case 18:

                        try
                        {
                            aList.RemoveCycle();
                            break;
                        }
                        catch (Exception anExpected)
                        {
                            Console.WriteLine(anExpected.Message);
                            continue;
                        }
                    case 19:
                        // TO DO
                        break;
                    //case 20:
                    //    Console.WriteLine("Enter the element to inserted >>");
                    //    data = Convert.ToInt32(Console.ReadLine());
                    //    aList.InsertInEmptyList(data);
                    //    break;
                    //case 21:
                    //    Console.WriteLine("Enter the element to inserted >>");
                    //    data = Convert.ToInt32(Console.ReadLine());
                    //    aList.InsertInTheBeginning(data);
                    //    break;
                    default:
                        Console.WriteLine("Wrong choice :");
                        break;
                }

                //part II.
                SingleLinkedList listOne = new SingleLinkedList();
                SingleLinkedList listTwo = new SingleLinkedList();

                listOne.CreateList();
                listTwo.CreateList();

                listOne.BubbleSortExData();
                listOne.BubbleSortExData();

                Console.WriteLine("First List - ");
                listOne.DisplayTheList();

                Console.WriteLine("Second List - ");
                listTwo.DisplayTheList();

                SingleLinkedList listThree;

                listThree = listOne.MergeOne(listTwo);
                Console.WriteLine("The Merged list - ");
                listThree.DisplayTheList();

                Console.WriteLine("The First list - ");
                listOne.DisplayTheList();

                Console.WriteLine("The Second list - ");
                listTwo.DisplayTheList();

                listThree = listOne.MergeTwo(listTwo);
                Console.WriteLine("The Merged list - ");
                listThree.DisplayTheList();

                Console.WriteLine("The First list - ");
                listOne.DisplayTheList();

                Console.WriteLine("The Second lipst -");
                listTwo.DisplayTheList();

                Console.WriteLine();
            }
            Console.WriteLine("Exit To Be continue....");
        }
    }
}
