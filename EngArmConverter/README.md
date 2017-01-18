
# **EngArmConverter**

**EngArmConverter extension method** converts armenian words written in english letters to armenian letters.

#**EngArm class**
Here you can see *Double letters' convertion* codes and *Single letters' convertion* codes.

#**TestingProgram**
This part is for users. 

```C#
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
```
In the above mentioned code, users can write sentence which they want to convert.

#**Output**



