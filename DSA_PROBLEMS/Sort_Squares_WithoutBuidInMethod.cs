using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal class Practice29
    {
        /*
         Given an Integer array 'a' sorted in non-decreasing order, return an arry of the square of each number sorted in non 
         -Decreasing order.
        */

        public static void Sort_Squares()
        {
            #region Method1
            /*  int[] arr = { -10, -3, -2, 1, 4, 5 };
              int k = 0;
              for (int i = 0; i < arr.Length; i++)
              {
                  arr[k++] = arr[i] * arr[i];
              }            
              Console.WriteLine("Square of Number Before Sorting  ");
              for (int i = 0; i < arr.Length; i++)
              {
                  Console.Write(arr[i] + " ");
              }

              for (int i = 0; i < arr.Length; i++)
              {
                  for (int j = i + 1; j < arr.Length; j++)
                  {
                      if (arr[i] > arr[j])
                      {
                          int temp = arr[i];
                          arr[i] = arr[j];
                          arr[j] = temp;
                      }
                  }
              }

              Console.WriteLine();
              Console.WriteLine("Square of Number After Sorting  ");
              for (int i = 0; i < arr.Length; i++)
              {
                  Console.Write(arr[i] + " ");
              }
            */
            #endregion Method1

            #region Method2

            int[] arr = { -10, -3, -2, -1, 4, 5 };
            int left = 0; int right = arr.Length - 1;
            int k = 0;
            int[] ans = new int[arr.Length];
            while (left <= right)
            {
                if ((Math.Abs(arr[left])) > (Math.Abs(arr[right])))
                {
                    ans[k++] = arr[left] * arr[left];
                    left++;
                }
                else
                {
                    ans[k++] = arr[right] * arr[right];
                    right--;
                }
            }

            var x = ans.OrderBy(x => x).ToArray();


            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
            #endregion Method2
        }
    }
}
