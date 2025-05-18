using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal class Practice37
    {
        /*
          Given a Matrix 'a' of dimension nXm and 2 coordinate (l1,r1) and (l2,r2) .
          Return the sum of the rectangle from (l1,r1) to (l2,r2).
          * l2>=l1 , r2>=r1
          * 0<=l1,l2<n,
          * 0<=r1,r2<m 
           */

        /*
         * 
        //METHOD 1ST
        public static void Prefix_Sum_2D_Array()
        {
          
            int[,] arr = { {1,1,1,1,1 }, { 1,1,1,1,1}, { 1,1,1,1,1},{1,1,1,1,1 },{1,1,1,1,1 } };
            int l1 = 2, r1 = 1, l2 = 3, r2 = 3;

            int sum = 0;
            for(int i = l1; i <= l2; i++)
            {
                for(int j = r1; j <=r2 ; j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(sum);
        }
       */

        /*METHOD 2ND*/

        /*
         Row Prefix-Sum
            1 2 3 4 5
            1 2 3 4 5
            1 2 3 4 5
            1 2 3 4 5
            1 2 3 4 5

         Column Prefix-Sum
            1 2 3 4 5
            2 4 6 8 10
            3 6 9 12 15
            4 8 12 16 20
            5 10 15 20 25

        TotalSum: 16
        TopSum: 8
        LeftSum: 4
        TopLeftSum: 2
        Actual Sum: 6
         
         */
        //METHOD 2ND
        /**
        public static void PrintArray(int[,] arr, string text)
        {
            Console.WriteLine(text);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] PrefixSum_Row_And_Column(int[,] arr, int row, int col)
        {
            int[,] prefixSum_Row = new int[row, col];

            // Row-wise prefix sum
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j == 0)
                        prefixSum_Row[i, j] = arr[i, j];
                    else
                        prefixSum_Row[i, j] = prefixSum_Row[i, j - 1] + arr[i, j];
                }
            }

            PrintArray(prefixSum_Row, "Row Prefix-Sum");

            int[,] prefixSum_Column = new int[row, col];

            // Column-wise prefix sum from row-wise prefix
            for (int j = 0; j < col; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    if (i == 0)
                        prefixSum_Column[i, j] = prefixSum_Row[i, j];
                    else
                        prefixSum_Column[i, j] = prefixSum_Column[i - 1, j] + prefixSum_Row[i, j];
                }
            }

            PrintArray(prefixSum_Column, "Column Prefix-Sum");
            return prefixSum_Column;
        }

        public static void Prefix_Sum_2D_Array()
        {
            int[,] arr = {
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 }
            };

            int l1 = 2, r1 = 1, l2 = 3, r2 = 3;
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);

            int [,] PrefixSumArray = PrefixSum_Row_And_Column(arr, row, col);

            int totalSum = PrefixSumArray[l2, r2];
            Console.WriteLine("TotalSum: " + totalSum);

            int topSum = PrefixSumArray[l1-1, r2];
            Console.WriteLine("TopSum: " + topSum);
            int leftSum = PrefixSumArray[l2, r1-1];
            Console.WriteLine("LeftSum: "+ leftSum);

            int topLeftSum = PrefixSumArray[l1-1, r1-1];
            Console.WriteLine("TopLeftSum: " + topLeftSum);

            int actualSum = totalSum - topSum - leftSum + topLeftSum;
            Console.WriteLine("Actual Sum: "+  actualSum);

        }
        */

        //METHOD 3rd

        public static int[,] PrefixSum_Row(int[,] arr, int row, int col)
        {
            int[,] prefixSum_Row = new int[row, col];

            // Row-wise prefix sum
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j == 0)
                        prefixSum_Row[i, j] = arr[i, j];
                    else
                        prefixSum_Row[i, j] = prefixSum_Row[i, j - 1] + arr[i, j];
                }
            }

            int[,] prefixSum_Column = new int[row, col];
            return prefixSum_Column;
        }

        public static void Prefix_Sum_2D_Array()
        {
            int[,] arr = {
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 }
            };
            int l1 = 2, r1 = 1, l2 = 3, r2 = 3;
            int sum = 0;
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);

            int[,] PrefixSumArray = PrefixSum_Row(arr, row, col);

            for(int i = l1; i <= l2; i++)
            {
                if (r1>=1)
                {
                    sum += PrefixSumArray[i, r2] - PrefixSumArray[i, r1 - 1];
                }
                else
                {
                    sum += PrefixSumArray[i, r2];
                }
                

            }
            Console.WriteLine(sum);
        }
    }
}
