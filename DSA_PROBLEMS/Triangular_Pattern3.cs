using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal  static class Practice14
    {
        public static void TRIANGULAR_PATTERN3()
        {
            //1
            //1 2
            //1 2 3
            //1 2 3 4
            for(int i=0;i<4;i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(j+1 +" ");
                }
                Console.WriteLine();
            }

        }
    }
}
