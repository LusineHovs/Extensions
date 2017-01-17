using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var eng = "barev";
            eng.engarmConverter();
            string[] st = new string[eng.Length];
            for (int i = 0; i < eng.Length; i++)

            {
                st[i] = eng.engarmConverter()[i];
            }
            for (int i = 0; i <eng.Length; i++)
            {
                Console.WriteLine(st[i]);
            }
        }
    }
}
