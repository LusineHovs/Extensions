using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class PrimitiveTypes
    {
        public static double Cos(this int value)
        {
            return Math.Cos(value);
        }

        public static bool isPrime(this int value)
        {
            for (int i = 1; i <= value / 2; i++)
            {
                if (value%2==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
