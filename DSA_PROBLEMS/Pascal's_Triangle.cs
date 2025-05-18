using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal class Practice35
    {
        /*         
                     1
                   1   1
                 1   2   1
               1   3    3   1
            1    4    6   4    1
       */
        /*
             1
             1   1
             1   2   1
             1   3   3   1
             1   4   6   4   1
         */

        public static void Pascal_s_Triangle()
        {
            int n = 5;
          
            int[,] ans = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        ans[i,j] = 1;
                    }
                    else
                    {
                        ans[i,j] = ans[i-1,j - 1] + ans[i-1,j];
                    }
                }
            }
            for (int i = 0;i < n; i++)
            {
                for(int j = 0;j <= i; j++)
                {
                    Console.Write( " "+ans[i,j]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
