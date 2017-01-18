using ExtensionMethod2;
using Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "abba";
            input.isPalindrome();
            Console.WriteLine(input.isPalindrome());

            var value = 120;
            value.Cos();
            Console.WriteLine(value.Cos());

            var value1 = 8;
            value1.isPrime();
            Console.WriteLine(value1.isPrime());
        }
    }
}
