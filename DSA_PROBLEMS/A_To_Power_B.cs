using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice6
    {
        public static int A_To_POWER_B()
        {

            int result = 1;
            Console.WriteLine("Enter A ::");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B ::");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 1;i<=b;i++)
            {
                result = result * a;
            }
            return result;
        }
    }
}
