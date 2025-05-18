using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal static class Practice27
    {
       
        /*
         Q.1 : Given an array of integer 'a'  move all the even integers at the beginning of the array folloed by all the odd
          integers . The relative order of odd or even integers doesn't matters . Return any array that satisfies the conditions.
        */
        /*
        public static void ODD_EVEN()
        {
            int[] arr = { 1, 3, 4, 5, 6,  8 };           
            int i = 0;
            int j = arr.Length - 1;

            while (i < arr.Length)
            {
                if ((arr[i]%2 == 0) && (arr[j]%2 != 0))
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;                   
                }
                i++; j--;
            }
            for(i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        */


        /*
        public static void Sort_0_and_1()
        {
            int[] arr = { 1, 0, 0, 1, 1, 0, 1, 0, 0, 0 };
            int n = arr.Length;
            int i = 0;
            int j = 0;
            while (i < n)
            {
                if (arr[i] == 0)
                {
                    arr[j++] = 0;
                }
                i++;
            }
            while (j < n)
            {
                arr[j++] = 1;
            }

            for (int k = 0; k < n; k++)
            {
                Console.Write(arr[k] + " ");
            }
        }

        */
        /*
        public static void Sort_0_and_1()
        {
            int[] arr = { 1, 1, 1, 0, 1, 0, 1, 0, 0, 0 };
            int n = arr.Length;
            int i = 0;
            int j = arr.Length-1;

            while (i < j)
            {
                if (arr[i]==1 && arr[j]==0)
                {
                    int temp= arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
                i++;
                j--;
            }
           
            for (int k = 0; k < n; k++)
            {
                Console.Write(arr[k] + " ");
            }
        }
        */
    }
}
