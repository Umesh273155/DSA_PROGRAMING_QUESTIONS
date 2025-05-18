using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice4
    {
        public static void SUM_OF_SERIES()
        {
            // S=1-2+3-4+5-6+7.......N;
            int n = 4;
            int oddSum = 0;
            int evenSum = 0;
            int ans = 0;
            for(int i = 1; i <= n; i++)
            {
                if (i%2!=0)
                {
                    ans -=  i;
                }
                else 
                {
                    evenSum= evenSum + i;
                }
            }
            int totalSum = oddSum - evenSum;
            Console.WriteLine("TOTAl SUM: " + totalSum);
        }
    }
}
