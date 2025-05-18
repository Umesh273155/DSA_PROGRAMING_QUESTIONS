using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PROBLEMS
{
    internal class Recursion
    {
        //1->2->3->4->5
        public static void PrintIncNumber(int n)
        {
            if (n==1)
            {
                Console.WriteLine(n);
                return;
            }
            PrintIncNumber(n-1);
            Console.WriteLine(n);
        }
        //5->4->3->2->1
        public static void PrintDescNumber(int start,int end)
        {
            if (start == end)
            {
                Console.WriteLine(start);
                return;
            }
            PrintDescNumber(start+1,end);
            Console.WriteLine(start);
        }
        public static int Factorial(int n)
        {
            if (n==1 || n==0)
            {
                return 1;
            }
          
             return n * Factorial(n - 1);
          
        }
        public static int Fibonaccy(int n)
        {
            if (n == 1 || n == 0)
            {               
                return n;
            }
            int prev = Fibonaccy(n - 1);
            int nextPrev = Fibonaccy(n - 2);
            return prev + nextPrev;
            //return Fibonaccy(n - 1) + Fibonaccy(n - 2);
        }
        public static int DigitsSum(int n)
        {
            if (n >= 0 && n<=9)
            {
                return n ;
            }           
            return DigitsSum(n / 10) + n % 10;
        }


        // Given two number p & q, find the value p^q using a recursive function.

        public static int P_to_Power_Q(int p, int q)
        {
           //Time Complexity: O(q)
         /* if (q == 0)
            {
                return 1;
            }
            return P_to_Power_Q(p, q - 1) * p;
           */

            //Time Complexity: O(q)

            if (q==0)
            {
                return 1;
            }

            int smallPow = P_to_Power_Q(p,q/2);
            if (q%2==0)
            {
                return smallPow*smallPow;
            }
            return smallPow * smallPow * p;
        }

        // Given a number num and a value k. print k multiple of num.

        /*
           constraints: k>0
           input: num=12 ,k=5                    num=3 , k=8
           Output: 12 , 24, 36 , 48, 60          3,6,9,12,15,18,21,24
         */
        public static int multipleOfNum(int num, int k)
        {
            if (k==1)
            {
                return num;
            }
            return multipleOfNum(num, k-1)*k;
        }

    }
}
