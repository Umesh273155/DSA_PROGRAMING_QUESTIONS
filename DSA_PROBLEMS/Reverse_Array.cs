using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal class Practice24
    {
        /***** Practice24: swap two numbers *****/
        //int a = 10; int b=20;
        //int temp = a;
        //a = b;
        //b = temp;
        //OR 
        //a = a + b;
        //b = a - b;
        //a = a - b;
        // Console.WriteLine("a: " + a + ", b: " + b);

        public static void REVERSE_ARRAY_SWAPING_METHOD()
        {
             int[] arr = { 1, 2, 3, 4, 5, 5 };
            //Console.WriteLine(String.Join(',', arr.Reverse()));

            //OR 
            int i = 0;int j = arr.Length-1;
            while(i < j){
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;               
            }
            Console.WriteLine(String.Join(',', arr));
        }
    }
}
