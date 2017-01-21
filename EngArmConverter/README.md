
# **EngArmConverter**

**EngArmConverter extension method** converts armenian words written in english letters to armenian letters.

#EngArm class
Here you can see *Double letters' convertion* codes and *Single letters' convertion* codes.

#TestingProgram
This part is for users. 

```C#
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
```
Below is the program's demonstration gif: you write armenian words written in english letters program converted it into armenian letters.

#Output

<img src="https://cloud.githubusercontent.com/assets/24455176/22144704/082e1ac0-df18-11e6-9989-b3debda35c58.gif" align="left"  />
