using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    public static class Practice19
    {
        //public static string DECIMAL_To_BINARY()
        //{
        //    int num = 10;
        //    string binary = "";
        //    while(num > 0)
        //    {
        //        int rem = num % 2;
        //        binary = rem + binary ;
        //        //binary = binary+rem;         
        //        num = num/2;
        //    }
        //    //binary= new string(binary.Reverse().ToArray());
        //    return binary;
        //}

        //public static string DECIMAL_To_BINARY()
        //{
        //    int num = 10;
        //    string binary = "";
        //    while(num > 0)
        //    {
        //        int rem = num % 2;    
        //        binary = binary+rem;
        //        num = num/2;
        //    }
        //    binary= new string(binary.Reverse().ToArray());
        //    return binary;
        //}
        public static string DECIMAL_To_BINARY()
        {
            int num = 10;
            int ans = 0;
            int place = 1;
            while (num > 0)
            {
                int rem = num % 2;
                ans  = ans + (rem * place);
                place = place*10;

                num = num / 2;
            }
            return ans.ToString();
        }
    }
}
