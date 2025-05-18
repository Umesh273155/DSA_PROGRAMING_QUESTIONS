using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice17
    {
        public static int[] SecondMax()
        {
            int[] arr = { 2, 3, 1, 0, 5, 6, 0, 1, 5, 6 };
            int[] res = new int[] { 0 };
            int max = int.MinValue;
            int secondmax = int.MinValue;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max <= arr[i])
                {
                    max = arr[i];
                    index = i;
                }
            }
          
            arr[index] = int.MinValue;
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (secondmax < arr[i] && arr[i] != max)
                {
                    secondmax= arr[i];
                }
            }

            res[0]= secondmax;
            return res;
        }
        public static int[]  First_Second_Third_MAX()
        {
            int[] x = new int[] { 0,0 ,0};
            int[] arr = { 2, 3, 1, 0, 5, 6 ,0 ,1,5,6};
            int firstMax = int.MinValue;
            int secondMax = int.MinValue;
            int thirdMax = int.MaxValue;
         
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>firstMax)
                {
                    thirdMax = secondMax;
                    secondMax = firstMax;
                    firstMax = arr[i];
                }
                else if(arr[i] > secondMax && arr[i]!=firstMax)
                {
                    thirdMax = secondMax;
                    secondMax = arr[i];
                    
                }else if (arr[i]> thirdMax && arr[i] != firstMax && arr[i] !=secondMax)
                {
                    thirdMax = arr[i];
                }
                x[0] = firstMax;
                x[1] = secondMax;
                x[2] = thirdMax;
            }
            return x;
        }
        public static int[] First_Second_Third_MIN()
        {
            int[] x = new int[] { 0, 0, 0 };
            int[] arr = { 2, 3, 1, 0, 5, 6, 0, 1, 5, 6 };
            int firstMin = int.MaxValue;
            int secondMin = int.MaxValue;
            int thirdMin = int.MaxValue;
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] < firstMin)
                {
                    thirdMin = secondMin;
                    secondMin = firstMin;
                    firstMin = arr[i];
                }
                else if (arr[i] < secondMin && arr[i] != firstMin)
                {
                    thirdMin = secondMin;
                    secondMin = arr[i];
                }
                else if (arr[i] < thirdMin && arr[i] != firstMin && arr[i] != secondMin)
                {
                    thirdMin = arr[i];
                }
                x[0] = firstMin;
                x[1] = secondMin;
                x[2] = thirdMin;
            }
            return x;
        }

        public static int[] NTH_MAX(int n)
        {
            int[] x = new int[] { 0};
            int[] arr = { 2, 3, 1, 0, 5, 6, 0, 1, 5, 6 ,6,6};
            int[] distinctSortedArr= arr.Distinct().OrderByDescending(x=>x).ToArray();
            if (n> distinctSortedArr.Length)
            {
                Console.WriteLine($"There are only {distinctSortedArr.Length} unique elements, so {n}th max does not exist.");
                return x;
            }
            else
            {
                x[0] = distinctSortedArr[n - 1];
                return x;
            }
        }
        public static int[] NTH_MIN(int n)
        {
            int[] x = new int[] { 0 };
            int[] arr = { 2, 3, 1, 0, 5, 6, 0, 1, 5, 6, 6, 6 };
            int[] distinctSortedArr = arr.Distinct().OrderBy(x => x).ToArray();
            if (n <= 0  && n > distinctSortedArr.Length)
            {
                Console.WriteLine($"There are only {distinctSortedArr.Length} unique elements, so {n}th max does not exist.");
                return x;
            }
            else
            {
                x[0] = distinctSortedArr[n - 1];
                return x;
            }
        }
    }
}
