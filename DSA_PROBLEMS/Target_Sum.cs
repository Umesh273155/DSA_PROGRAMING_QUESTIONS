using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice21
    {
        //Find the total number  of pairs in the array whose sum is equals to the given value x
        public static void TWICE_TARGET_SUM()
        {
            Console.WriteLine("Enter Array Size::");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter The Array Elements::");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Your Array Elements::");
            foreach(int i in arr)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter the Target Elements::");
            int target = int.Parse(Console.ReadLine()); 

            int count = 0;
            for(int i=0; i<arr.Length; i++)
            {
                for (int j=i+1;j<arr.Length; j++)
                { 
                    if ((arr[i] + arr[j]) == target)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        // Count the number of triplet sum 
        public static void TRIPLET_TARGET_SUM()
        {
            int count = 0; int target = 10;
            int[] arr = { 1,2,3,4,5,6,7,8};
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for(int k=j+1;k<arr.Length; k++)
                    {
                        if ((arr[i] + arr[j] + arr[k]) == target)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
