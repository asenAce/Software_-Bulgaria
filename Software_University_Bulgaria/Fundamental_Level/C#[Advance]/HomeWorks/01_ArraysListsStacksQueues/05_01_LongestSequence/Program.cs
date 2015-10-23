using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkFive.One.cs
{
    class Program
    {

        /*
         * 
         * Sequence in Matrix 
         * */
        static void Main(string[] args)
        {
            #region The input
            Console.WriteLine(" n = ");
            int modulOne = int.Parse(Console.ReadLine());

            Console.WriteLine(" m = ");
            int modulTwo = int.Parse(Console.ReadLine());

            string[,] matrix = new string[modulOne, modulTwo];

            List<string> final = new List<string>();

            #endregion The input
            # region The Logic

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = Console.ReadLine();
                }
                
            }
            // Horizontal

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                List<string> tempList = new List<string>();
                tempList.Add(matrix[row,0]);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == matrix[row,col - 1])
                    {
                        tempList.Add(matrix[row,col]);

                        if (col == matrix.GetLength(1) - 1)
	                        {
                                if (tempList.Count > final.Count)
                                {
                                    final.Clear();

                                    foreach (var item in tempList)
                                    {
                                        final.Add(item);
                                    }

                                    tempList.Clear();
                                    tempList.Add(matrix[row, col]);

                                }

                                else
                                {
                                    tempList.Clear();
                                    tempList.Add(matrix[row, col]);
                                }
	                        }              
                    }

                    else
                    {
                        if (tempList.Count > final.Count)
                        {
                            final.Clear();

                            foreach (var item in tempList)
                            {
                                final.Add(item);
                            }

                            tempList.Clear();
                            tempList.Add(matrix[row,col]);
                        }

                        else
                        {
                            tempList.Clear();
                            tempList.Add(matrix[row,col]);
                        }
                    }
                    
                }

            }

            // Vertical


            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                List<string> tempList = new List<string>();
                tempList.Add(matrix[0,row]);

                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (matrix[row,col] == matrix[row - 1,col])
                    {
                        tempList.Add(matrix[row,col]);

                        if (col == matrix.GetLength(0) - 1)
                        {
                            if (tempList.Count > final.Count)
                            {
                                final.Clear();

                                foreach (var item in tempList)
                                {
                                    final.Add(item);
                                }

                                tempList.Clear();
                                tempList.Add(matrix[row,col]);
                            }

                            else
                            {
                                tempList.Clear();
                                tempList.Add(matrix[row,col]);
                            }
                        }
                    }

                    else
                    {
                        if (tempList.Count > final.Count)
                        {
                            final.Clear();

                            foreach (var item in tempList)
                            {
                                final.Add(item);
                            }
                        }

                        else
                        {
                            tempList.Clear();
                            tempList.Add(matrix[row,col]);

                        }
                    }

                }
            }

            // Diagonal....

            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                List<string> tempList = new List<string>();
                tempList.Add(matrix[0, row]);

                for (int col = 1 , colTwo = 1; col < matrix.GetLength(0); col++,colTwo++)
                {
                    if (matrix[col,colTwo] == matrix[col - 1,colTwo -1])
                    {
                        tempList.Add(matrix[col,colTwo]);

                        if (col == matrix.GetLength(0) - 1)
                        {
                            if (tempList.Count > final.Count)
                            {
                                final.Clear();

                                foreach (var item in tempList)
                                {
                                    final.Add(item);
                                }

                                tempList.Clear();
                                tempList.Add(matrix[row,col]);
                                

                            }

                            else
                            {
                                tempList.Clear();
                                tempList.Add(matrix[row,col]);
                            }
                            
                        }
                    }

                    else
                    {
                        if (tempList.Count > final.Count)
                        {
                            final.Clear();

                            foreach (var item in tempList)
                            {
                                final.Add(item);
                            }

                            tempList.Clear();
                            tempList.Add(matrix[row,col]);


                        }

                        else
                        {
                            tempList.Clear();
                            tempList.Add(matrix[row,col]);

                        }

                    }
                }

            }
            #endregion The Logic

            #region The Output

            Console.WriteLine(String.Join(",", final));
            #endregion The Output


        }
    }
}
