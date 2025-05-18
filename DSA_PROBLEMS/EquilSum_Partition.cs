using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal static class Practice31
    {
        #region Method1
        /*
        public static void EquilSum_Partition()
        {
           
            int[] arr = { 5, 3, 2, 6, 3, 1 };
            //int[] arr = { 1,3,2,4,5 };
            int[] prefixArr= new int[arr.Length];
            int[] suffixArr = new int[arr.Length];

            Console.WriteLine("\nYOUR  ARRAY");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            prefixArr[0] = arr[0];
            suffixArr[arr.Length - 1] = arr[arr.Length-1];
            for (int i = 1; i < arr.Length; i++)
            {
                prefixArr[i] = prefixArr[i-1]+ arr[i];               
            }

            Console.WriteLine("\nPREFIX ARRAY");
            foreach (var item in prefixArr)
            {
                Console.Write(item+" ");
            }
         
            for (int i = arr.Length-2; i >=0 ; i--)
            {
                suffixArr[i] = suffixArr[i+1] + arr[i];
            }

            Console.Write("\nSUFFIX ARRAY:\n");
            foreach (var item in suffixArr)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine();
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < prefixArr.Length-1; i++)
            {
                if (!dic.ContainsKey(prefixArr[i]))
                {
                    dic.Add(prefixArr[i], 1);
                }
            }

            for (int i = 1; i < suffixArr.Length; i++)
            {
                if (dic.ContainsKey(suffixArr[i]))
                {
                    Console.WriteLine("Equil Sum :"+  suffixArr[i]);
                    Console.WriteLine("true");
                    return;
                }
            }

                Console.WriteLine("false");
        }
        */

        #endregion Method1


        #region METHOD2
        public static int MakeTotalSum(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
               sum += arr[i];
            }
            return sum;
        }
        public static void EquilSum_Partition()
        {
           // int[] arr = { 5, 3, 2, 6, 3, 1 };
            int[] arr = { 1, 3, 2, 4, 5 };
            int TotalSum = MakeTotalSum(arr);

            int[]prefix= new int[arr.Length];
            prefix[0] = arr[0];
            for (int i=1;i<arr.Length;i++)
            {
                prefix[i]= prefix[i-1]+arr[i];
            }
            Console.WriteLine("PrefixArray:: ");
            foreach(var item in prefix)   
            {
                Console.Write(item+" ");
            }
           
            int[] suffix = new int[arr.Length];

            for ( int j=0;j<arr.Length;j++)
            {
                suffix[j]= TotalSum - prefix[j];
                if (suffix[j] == prefix[j])
                {
                    Console.WriteLine("TRUE");
                    return;
                }
            }

            Console.WriteLine("FALSE");
            return;
        }
       
        #endregion METHOD2
    }
}
