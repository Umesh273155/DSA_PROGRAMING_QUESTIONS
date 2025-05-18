using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal class Practice15
    {
        public static void TRIANGULAR_PATTERN4()
        {
            //      1
            //    1 2 1
            //  1 2 3 2 1
            //1 2 3 4 3 2 1
            int row = 4;
            for(int i=0;i<row; i++)
            {
                int count = 1;
                for(int j=0;j< row; j++)
                {
                    if (j <  row-1-i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(count);
                        count++;
                    }
                }
                for (int j=i;j>0;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
