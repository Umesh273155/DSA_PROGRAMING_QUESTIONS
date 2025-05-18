using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal class Practice12
    {
        public static void RECTANGULAR_PATTERN3()
        {
             //1 2 3 4 5 6 7
             //2 3 4 5 6 7 1
             //3 4 5 6 7 1 2
             //4 5 6 7 1 2 3
             //5 6 7 1 2 3 4
             //6 7 1 2 3 4 5
             //7 1 2 3 4 5 6

             for(int i=0;i<7;i++)
             {
                for (int j = i + 1; j <= 7; j++)
                {
                    Console.Write(j + " ");
                }

                for(int j=1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
              Console.WriteLine();
            }
        }
    }
}
