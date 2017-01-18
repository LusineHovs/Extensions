using ExtensionMethod1;
using System;

namespace TestingProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            var eng = "barev usucich :)";
            eng.engarmConverter();
            string[] st = new string[eng.Length];
            for (int i = 0; i < eng.Length; i++)

            {
                st[i] = eng.engarmConverter()[i];
            }
            for (int i = 0; i < eng.Length; i++)
            {
                Console.Write(st[i]);
            }
            Console.ReadKey();

        }
    }
}
