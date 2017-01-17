using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod1
{
    public static class EngArm
    {
        public static string[] engarmConverter(this string engWord)
        {
            string[] armLetter = new string[engWord.Length];

            for (int i = 0; i < engWord.Length; i++)
            {
                if (i != engWord.Length - 1)
                {
                    if (engWord.Substring(i, 2) == "ev")
                    { armLetter[i] = "և";
                       i=i+2;
                    }
                }
                
                if (engWord[i] == 'a') armLetter[i] = "ա";
                if (engWord[i] == 'b') armLetter[i] = "բ";
                if(engWord[i] == 'c') armLetter[i] = "ց";
                if(engWord[i] == 'd') armLetter[i] = "դ";
                if(engWord[i] == 'e') armLetter[i] = "ե";
                if(engWord[i] == 'f') armLetter[i] = "ֆ";
                if(engWord[i] == 'g') armLetter[i] = "գ";
                if(engWord[i] == 'h') armLetter[i] = "հ";
                if(engWord[i] == 'i') armLetter[i] = "ի";
                if(engWord[i] == 'j') armLetter[i] = "ջ";
                if(engWord[i] == 'k') armLetter[i] = "կ";
                if(engWord[i] == 'l') armLetter[i] = "լ";
                if(engWord[i] == 'm') armLetter[i] = "մ";
                if(engWord[i] == 'n') armLetter[i] = "ն";
                if(engWord[i] == 'o') armLetter[i] = "օ";
                if(engWord[i] == 'p') armLetter[i] = "պ";
                if(engWord[i] == 'q') armLetter[i] = "ք";
                if(engWord[i] == 'r') armLetter[i] = "ր";
                if(engWord[i] == 's') armLetter[i] = "ս";
                if(engWord[i] == 't') armLetter[i] = "տ";
                if(engWord[i] == 'u') armLetter[i] = "ու";
                if(engWord[i] == 'v') armLetter[i] = "ո";
                if(engWord[i] == 'w') armLetter[i] = "վ";
                if(engWord[i] == 'x') armLetter[i] = "խ";
                if(engWord[i] == 'y') armLetter[i] = "յ";
                if(engWord[i] == 'z') armLetter[i] = "զ";
                if(engWord[i] == '@') armLetter[i] = "ը";
                
            }
            return armLetter;
        }
    }
}
