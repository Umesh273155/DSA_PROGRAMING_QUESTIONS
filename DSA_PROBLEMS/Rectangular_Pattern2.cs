using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice8
    {
        public static void RECTANGULAR_PATTERN2()
        {
            //*****
            //*   *
            //*****
            int a = 5; int b = 5;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i == 0 || i == (a-1))
                    {
                        Console.Write("* ");
                    }
                    else if (j == 0 || j == (b-1))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }                        
                }
                Console.WriteLine(" ");
            }
        }
    }
}
