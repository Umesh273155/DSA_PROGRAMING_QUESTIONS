using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal static class Practice26
    {
        //Rotate the given array 'a' by k-steps,where k is non-negative
        //k=0  1,2,3,4,5
        //k=1  5,1,2,3,4
        //k=2  4,5,1,2,3
        //k=3  3,4,5,1,2
        //k=4  2,3,4,5,1
        //k=5 1,2,3,4,5

        //WITHOUT USING EXTRA SPACES


        public static void RotateInPlace(int[] arr,int k)
        {
             k=k%arr.Length;
             int n = arr.Length;
             reverse(arr,0,n-k-1);
             reverse(arr, n - k, n - 1);
             reverse(arr, 0, n - 1);           
        }

        public static void reverse(int[] arr,int i,int j)
        {
            while(i<j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }
        public static void K_Step_Rotation()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 2;
            RotateInPlace(arr, k);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            
        }


        /*
               //USING EXTRA SPACES
               public static void K_Step_Rotation()
               {
                   int k = 2;
                   int[] arr = { 1, 2, 3,4,5 };

                   k=k%arr.Length;
                   int[] newArr = new int[arr.Length];
                   int j = 0;

                   for(int i = 0; i < arr.Length; i++)
                   {
                       if (i<k)
                       {
                           newArr[j++] = arr[arr.Length-k+i];
                       }
                   }
                   for(int x = 0; x < arr.Length-k; x++)
                   {
                       newArr[j++] = arr[x];
                   }
                   for (int l = 0; l < newArr.Length; l++)
                   {
                       Console.WriteLine(newArr[l]);
                   }
               }
          */

        /*
        //int[] arr = { 1, 2, 3,   4, 5, 6,   7, 8, 9,  10,11,12 ,13,14 };
        //Output:: {3,2,1,  6,5,4, 9,8,7, 12,11,10, 13,14 }

        public static void K_Step_Rotation_InGroup()
        {
            int step = 3;
            int[] arr = { 1, 2, 3,   4, 5, 6,   7, 8, 9,  10,11,12 ,13,14 };
          
            int i = 0;
            int j = step - 1;
            int k = step;
            int count = 1;
            while (i < arr.Length)
            {
                if (i < j && j < arr.Length)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j--;
                    i++;
                }
                else
                {
                    i = k;
                    j = count * step - 1;
                    count++;
                    k = j + 1;
                }
            }
            for (int l = 0; l < arr.Length; l++)
            {
                Console.WriteLine(arr[l]);
            }
        }
        */
    }
}
