using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal static class Practice23
    {
        public static void FIRST_REPEATED_ELEMENT()
        {
            //int[] arr = { 1,5,3,4,6,3,4};
            //Dictionary<int , int> dic= new Dictionary<int , int>();
            //int index = 0;
            //int first_Repeated_element = int.MinValue;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (!dic.ContainsKey(arr[i]))
            //    {
            //        dic.Add(arr[i], 1);
            //    }
            //    else
            //    {
            //        first_Repeated_element = arr[i];
            //        index= i;
            //        break;
            //    }
            //}
            //Console.WriteLine("Index: " + index);
            //Console.WriteLine("first_Repeated_element : " + first_Repeated_element);
            
            //OR 
           
            int[] arr = { 1, 5, 3, 4, 6, 3, 4 };
             for(int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("Index: " + i);
                        Console.WriteLine("FirstRepeatedElement: " + arr[i]);
                        return;
                    }
                }
            }
        }
    }
}
