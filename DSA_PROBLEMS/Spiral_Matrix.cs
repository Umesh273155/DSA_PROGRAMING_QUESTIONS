using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal class Practice36
    {

        public static void Spiral_Matrix()
        {
            /*
             1 2 3
             4 5 6 :: output: 1 2 3 6 9 8 7 4 5
             7 8 9
             */
          
            int[,]arr= { { 1, 2, 3 ,1}, { 4, 5, 6,8 }, { 7, 8, 9 ,7} };
            int row = 3; int col = 4;

            int totalNumber = 0; int startrow = 0;int endrow = row-1; int startcol = 0; int endcol = col - 1;
           
            while (totalNumber < row*col)
            {
                for(int i = startcol; i <= endcol && (totalNumber < row * col); i++) {
                    Console.Write(arr[startrow, i]+" ");
                    totalNumber++;
                }
                startrow++;

                for (int j = startrow; j <= endrow && (totalNumber < row * col); j++)
                {
                    Console.Write(arr[j, endcol] +" "); 
                    totalNumber++;
                }
                endcol--;

                for (int k = endcol; k >= startcol && (totalNumber < row * col); k--)
                {
                    Console.Write(arr[endrow,k] + " ");
                    totalNumber++;
                }
                endrow--;

                for (int l = endrow; l >= startrow && (totalNumber < row * col); l--)
                {
                    Console.Write(arr[l, startcol] + " ");
                    totalNumber++;
                }
                startcol++;
            }
        }

        public static void Spiral_Matrix_ArrayPrinting()
        {
            /*
              Given a positive integer n, generate an nXn matrix filled with elements from 1 to n^2 in spiral Order;
              int n=3  OUTPUT=>

               1 2 3
               8 9 4
               7 6 5
             */

            int n = 3;

            int totalNumber = 0; int startrow = 0; int endrow = n - 1; int startcol = 0; int endcol = n - 1;int current = 1;
            int[,]ans = new int[n,n];    

            while (totalNumber < n*n)
            {
                for (int i = startcol; i <= endcol && (totalNumber < n * n); i++)
                {
                    ans[startrow, i] = current; 
                    current++;
                    totalNumber++;
                }
                startrow++;

                for (int j = startrow; j <= endrow && (totalNumber < n * n); j++)
                {
                    ans[j, endcol]= current;
                    current++;
                    totalNumber++;
                }
                endcol--;

                for (int k = endcol; k >= startcol && (totalNumber < n * n); k--)
                {
                    ans[endrow, k]= current;
                    current++;
                    totalNumber++;
                }
                endrow--;

                for (int l = endrow; l >= startrow && (totalNumber < n * n); l--)
                {
                    ans[l, startcol]= current;
                    current++;
                    totalNumber++;
                }
                startcol++;
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(ans[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
