using ExtensionMethod1;
using System;

namespace TestingProgram
{
    class Program
    {
        static void Main(string[] args)
        {

       var eng = Console.ReadLine();
       var engLower= eng.ToLower();
       engLower.engarmConverter();
       string[] st = new string[engLower.Length];
       for (int i = 0; i < engLower.Length; i++)

        {
            st[i] = engLower.engarmConverter()[i];
        }
        for (int i = 0; i < engLower.Length; i++)
        {
            Console.Write(st[i]);
        }
        Console.ReadKey();

        }
    }
}
