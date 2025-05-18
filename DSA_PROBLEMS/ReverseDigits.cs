using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice3
    {
        public static void REVERSEDIGITS()
        {
            Console.WriteLine("Enter Your Number For Reverse");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            //string newStr = "";
            while (num>0)
            {
                int rem = num % 10;
                sum = sum * 10 + rem;
                num = num / 10;

                //OR 

                //int rem = num % 10;
                //newStr= newStr + rem;
                //num = num / 10;
            }
            Console.WriteLine(sum);

            //Console.WriteLine(Convert.ToInt32(newStr));
        }
    }
}
