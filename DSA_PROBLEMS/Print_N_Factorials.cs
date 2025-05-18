using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal static class Practice5
    {
        public static void PRINT_N_FACTORIALS()
        {
            int n = 1;
            int fact = 1;
            Console.WriteLine("Enter Max NUMBER::");
            var num = Convert.ToInt32(Console.ReadLine());

            while(n <= num)
            {
                fact = fact * n;
                Console.WriteLine(fact);
                n++;
            }
        }
    }
}
