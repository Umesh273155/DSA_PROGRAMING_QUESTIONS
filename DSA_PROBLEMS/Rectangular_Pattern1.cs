using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice7
    {
        public static void RECTANGULAR_PATTERN1()
        {
            //*****
            //*****
            //*****

            int a = 3;int b = 5;

            for(int i= 0; i < a; i++)
            {
                for(int j= 0; j < b; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
