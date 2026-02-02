using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class PalindromeNumber9
    {
        public static void Display()
        {
            Console.WriteLine(Solution(123));
            Console.WriteLine(Solution(121));
            Console.WriteLine(Solution(-121));
        }

        private static bool Solution(int x)
        {
            int res = 0;
            int temp = x;

            while (temp > 0)
            {
                res = (res * 10) + (temp % 10);
                temp /= 10;
            }

            return x == res;
        }
    }
}
