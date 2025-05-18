using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal static class Practice13
    { 
        public static void RECTANGULAR_PATTERN4()
        {
           //1 2 1 2 1 2
           //2 1 2 1 2 1 
           //1 2 1 2 1 2
           //2 1 2 1 2 1
            for(int i=0;i<4;i++)
            {
              for(int j=0;j<6;j++)
                {
                    if ((i+j)%2==0)
                    { 
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("2 ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
