using System;

namespace DSA_PROBLEMS
{
    internal class Practice33
    {
        public static void Transpose_Of_Matrix()
        {
            Console.WriteLine("Enter number of rows in Matrix:");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of columns in Matrix:");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[row, col];

            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

           int[,] transpose = new int[col, row];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                     transpose[j, i] = arr[i, j];
                }
            }

            Console.WriteLine("Transpose of the matrix is:");
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(transpose[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
