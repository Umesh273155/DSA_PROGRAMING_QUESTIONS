using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice11
    {
        public static void PYRAMID_PATTERN1()
        {
            //   *
            //  ***
            // *****
            //*******
            int a = 4;
            for(int i=(a-1);i>=0;i--) { 
              for(int j=0;j<a;j++)
              {
                    if (j < i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
              }
               
               for ( int j = i;j <a;j++)
                {
                    if (i==j)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write("*");
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
