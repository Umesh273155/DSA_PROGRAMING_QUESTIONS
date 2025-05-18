using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice22
    {
        public static void Unique_Element_In_Array()
        {
            int[] arr = { 10, 10, 20, 20, 40, 40, 5, 6, 5, 6, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = 0; j < arr.Length; j++)
                {
                    if ((arr[i] == arr[j]) && i != j)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
            }

            //OR 

            //int[] arr = { 10, 10, 20, 20, 100, 40, 40, 5, 6, 5, 6 };
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < arr.Length; i++)
            //{               
            //    if (dic.ContainsKey(arr[i]))
            //    {
            //        dic.Remove(arr[i]);                   
            //    }
            //    else
            //    {
            //        dic.Add(arr[i], i);
            //    }
            //}
            //foreach (var item in dic)
            //{
            //    Console.WriteLine("KEY: "+ item.Key);
            //    Console.WriteLine("VALUE: "+ item.Value);
            //}
        }
    }
}
