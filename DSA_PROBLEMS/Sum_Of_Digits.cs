using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice1
    {
        public static void DigitsSum()
        {
            int n = 12345678;
            int sum = 0;
            while (n > 0)
            {
                int rem = n % 10;
                sum = sum + rem;
                n = n / 10;

            }
            Console.WriteLine("Digits Sum:: "+sum);
        }

    }
}
