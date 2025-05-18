using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal class Practice34
    {
           /*
            1 2 4       7 4 1 
            4 5 6  ===> 8 5 2
            7 8 9       9 6 4              
           */

        public static void Matrix_Rotation_90_Degree()
        {
            int row = 3; int col = 3;
            int[,] arr = new int[row, col];
            Console.WriteLine("Enter Array Element with Size: 3X3 ");

            for (int m = 0; m < row; m++)
            {
                for (int n = 0; n< col; n++)
                {
                    arr[m, n] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] transpose = TransposeOfMatrix(arr,row,col);
            Console.WriteLine("TransposeOfMatrix");

            PrintArray(transpose, row, col);

            for(int x = 0 ; x < row; x++)
            {
                int start = 0;
                int end = col - 1;
                while (start < end)
                {
                    int temp = transpose[x,start];
                    transpose[x, start] = transpose[x,end];
                    transpose[x, end]= temp;
                    start++;
                    end--;
                }
            }

            Console.WriteLine("After Rotation of 90 Degere");
            PrintArray(transpose,row,col);
           
        }
        public static int[,] TransposeOfMatrix(int[,] arr, int row, int col)
        {
            int[,] transpose = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    transpose[j, i] = arr[i, j];
                }
            }
            return transpose;
        }
        public static void PrintArray(int[,] arr, int row, int col)
        {
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    Console.Write(arr[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
