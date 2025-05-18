using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice10
    {
        public static void TRIANGULAR_PATTERN2()
        {
            //****
            //***
            //**
            //*
            int a = 4;

            for (int i = a-1 ; i >=0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
