using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice20
    {
        public static int Last_Occurance_Of_Element()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 integers::");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You entered array:");
            Console.Write(" [ ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.Write(" ] ");
            Console.WriteLine();

            Console.WriteLine("Enter The Element::");
            int index = 0;
            int element = int.Parse(Console.ReadLine());

            for(int i=0;i<arr.Length;i++)
            {
                if (element == arr[i])
                {
                    index = i;
                }  
            }
            return index;
        }
    }
}
