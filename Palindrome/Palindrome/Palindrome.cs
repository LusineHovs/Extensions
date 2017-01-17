using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod2
{
    public static class Extension
    {
        public static bool isPalindrome(this string input)
        {
            input = input.ToLower();

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
 }

