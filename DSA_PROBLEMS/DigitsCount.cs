using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice2
    {
        public static void DigitsCount()
        {
            int n = 12345678;
            int count = 0;
            while (n > 0)
            {
                 n = n / 10;
                count = count + 1;
            }
            Console.WriteLine("Digits Count::" + count);
        }
    }
}
