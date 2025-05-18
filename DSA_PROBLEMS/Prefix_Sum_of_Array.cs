using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal static class Practice30
    {
        public static void Prefix_Sum_of_Array()
        {
            #region Method1
            /*
            int[] arr = {1,2,3,4,5 };
            int[] ans= new int[arr.Length];
            for (int i=arr.Length-1;i>=0;i--)
            {
                int sum = 0;
                for (int j=0;j<=i;j++)
                {
                    sum = sum + arr[j];
                }
                ans[i] = sum;
            }
            foreach (int item in ans)
            {
                Console.Write(item+" ");
            }
            */
            #endregion Method1

            #region Method2

            int[] arr = { 1, 2, 3, 4, 5 };
            arr[0] = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }

            #endregion Method2
        }

        /*
            Q.2: Given an array of integers of size n. Answer Q queries   where you need to print the sum of values in a given 
            range of indices from 1 to R (both included)
            NOTE: The values of 1 and R in queries follow 1-based indexing. :: (In C# only 0 Based indexing Present)

        */

        #region Method1
        /*
        public static int Array_Sum(int[] arr, int L ,int R)
        {
            int sum = 0;
            L = L - 1;
            R = R - 1;

            if (L<0 || R<0 ||  L>arr.Length  || R >arr.Length )
            {
                return sum;
            }
            for (int i = L; i <= R; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

        public static void sumofArray_Q_queries()
        {
            Console.WriteLine("Enter the size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter the array Elements:");
            for (int j = 0; j < size; j++)
            {
                arr[j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your Choosen Array: ");
            for (int j = 0; j < size; j++)
            {
                Console.Write(arr[j] + ", ");
            }

            Console.WriteLine("\nEnter the number of queries:");
            int Q = int.Parse(Console.ReadLine());

            for (int i = 0; i < Q; i++)
            {
                Console.WriteLine("\nEnter the starting Range  L:");
                int L = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the limiting Range R:");
                int R = int.Parse(Console.ReadLine());

                int Result = Array_Sum(arr, L,R);
                Console.WriteLine("Sum:: " + Result);
            }
        }
      */
        #endregion Method1

        #region Method2

        /*
        Q.2: Given an array of integers of size n. Answer Q queries where you need to print the sum of values in a given 
        range of indices from 1 to R (both included)
        NOTE: The values of 1 and R in queries follow 1-based indexing. :: (In C# only 0 Based indexing Present)
        */

        public static int Array_Sum(int[] prefixSum, int L, int R)
        {
            L = L - 1;
            R = R - 1;

            if (L == 0)
                return prefixSum[R];
            else
                return prefixSum[R] - prefixSum[L - 1];
        }

        public static void Prefix_Sum_Array(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i];
            }
        }

        public static void sumofArray_Q_queries()
        {
            Console.WriteLine("Enter the size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter the array Elements:");
            for (int j = 0; j < size; j++)
            {
                arr[j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your Chosen Array:");
            for (int j = 0; j < size; j++)
            {
                Console.Write(arr[j] + " ");
            }

            // Step 1: Convert the array into prefix sum array
            Prefix_Sum_Array(arr);

            Console.WriteLine("\nPrefix Sum Array:");
            for (int j = 0; j < size; j++)
            {
                Console.Write(arr[j] + " ");
            }

            Console.WriteLine("\nEnter the number of queries:");
            int Q = int.Parse(Console.ReadLine());

            // Step 2: Process queries
            for (int i = 0; i < Q; i++)
            {
                Console.WriteLine("\nEnter the starting Range L (1-based):");
                int L = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the limiting Range R (1-based):");
                int R = int.Parse(Console.ReadLine());

                int result = Array_Sum(arr, L, R);
                Console.WriteLine("Sum:: " + result);
            }
        }

        #endregion Method2

    }
}
