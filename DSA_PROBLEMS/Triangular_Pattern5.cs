using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal static class Practice16
    {
        public static void TRIANGULAR_PATTERN5()
        {
            //      1
            //    2   2
            //  3        3
            //4 4 4 4 4 4 4

            int a = 4;
            for(int i=0;i<a;i++)
            {
                for(int j = 0; j < a; j++)
                {
                    if (i == a - 1)
                    {
                        Console.Write(i + 1);
                    }
                    else if (j == a-1-i)
                    {
                        Console.Write(i+1);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                for(int j = 0; j < i; j++)
                {
                    if (i == a - 1)
                    {
                        Console.Write(i + 1);
                    }
                    else if (j == (i-1))
                    {
                        Console.Write(i + 1);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
