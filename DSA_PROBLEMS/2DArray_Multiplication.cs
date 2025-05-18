using System;

namespace DSA_PROBLEMS
{
    internal static class Practice32
    {
        public static void _2DArrayMultiplication()
        {
            Console.WriteLine("Enter the number of rows for Matrix 1:");
            int rows1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns for Matrix 1:");
            int cols1 = int.Parse(Console.ReadLine());

            int[][] arr1 = new int[rows1][];
            Console.WriteLine("Enter elements for Matrix 1:");
            for (int i = 0; i < rows1; i++)
            {
                arr1[i] = new int[cols1];
                for (int j = 0; j < cols1; j++)
                {
                    arr1[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the number of rows for Matrix 2:");
            int rows2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns for Matrix 2:");
            int cols2 = int.Parse(Console.ReadLine());

            if (cols1 != rows2)
            {
                Console.WriteLine("Matrix multiplication not possible. Columns of Matrix1 must equal Rows of Matrix2.");
                return;
            }

            int[][] arr2 = new int[rows2][];
            Console.WriteLine("Enter elements for Matrix 2:");
            for (int i = 0; i < rows2; i++)
            {
                arr2[i] = new int[cols2];
                for (int j = 0; j < cols2; j++)
                {
                    arr2[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Result matrix will be rows1 x cols2
            int[][] result = new int[rows1][];
            for (int i = 0; i < rows1; i++)
            {
                result[i] = new int[cols2];
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++) // or k < rows2
                    {
                        result[i][j] += arr1[i][k] * arr2[k][j];
                    }
                }
            }

            Console.WriteLine("Result of Matrix Multiplication:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(result[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
