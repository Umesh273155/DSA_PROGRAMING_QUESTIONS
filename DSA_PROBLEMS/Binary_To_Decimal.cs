using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal static class Practice18
    {
        public static double BINARY_To_DECIMAL()
        {
            int binaryNumber = 101;
            double sum = 0;
            int count = 0;
            while (binaryNumber > 0)
            {
               
                int rem = binaryNumber % 10;

                sum = sum + rem*(Math.Pow(2, count));
                binaryNumber /= 10; 
                count++;
            }
           return sum;
        }
    }
}
