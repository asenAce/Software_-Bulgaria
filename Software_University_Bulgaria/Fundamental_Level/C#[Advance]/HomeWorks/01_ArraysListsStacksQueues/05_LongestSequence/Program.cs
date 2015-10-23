using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkFive.cs
{
    class Program
    {
        /*
         * Sequence in Matrix 
         * */

        static void Main(string[] args)
        {

            #region The Input

            string input;
            string[] rowStr;
            var matrix = new List<string[]>();

            #endregion The Input
            #region The Logic

            while (!((input = Console.ReadLine()) == "END"))
            {
                rowStr = input.Split(' ');
                matrix.Add(rowStr);
            }

            var maxLenght = new List<string>();

            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    maxLenght = SequeceCheck(matrix,row,col,1,0,maxLenght);
                    maxLenght = SequeceCheck(matrix, row, col, 0, 1, maxLenght);
                    maxLenght = SequeceCheck(matrix, row, col, 1, 1, maxLenght);
                    maxLenght = SequeceCheck(matrix, row, col, 1, -1, maxLenght);
                }
            }

            Console.WriteLine(string.Join(",",maxLenght));

        }

        private static List<string> SequeceCheck(List<string[]> matrix, int row, int col, int rowChange, int colChange, List<string> maxLenght);
    {

        int count = 1;

        while (row + rowChange >= 0 && row + rowChange < matrix.Count && col + colChange >= 0 && col + colChange < matrix[0].Lenght)
	        {
	            if (matrix[row][col] == matrix[row + rowChange][col + colChange])
	                    {
	                        	 count++;
	                    }

                 else
	                    {
                                     break;
	                    }

                         row += rowChange;
                         col += colChange;
	        }

        if (count > maxLenght.Count)
	    {
		 maxLenght.Clear();
            for (int i = 0; i < length; i++)
			{
			    maxLenght.Add(matrix[row][col]);
			}
	     }
        return maxLenght;
    }
        


            #endregion The Logic

        #region The Output
        #endregion The Output
    }
}
