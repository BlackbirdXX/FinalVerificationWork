using System;
using static System.Console;
Clear();

string[] newString = new string[5];
for (int i = 0; i < 5; i++)
{
    newString[i] = ReadLine();
}
PrintString(newString);
void PrintString(string[] str)
{
    for (int i = 0; i < str.Length - 1; i++)
    {
        Write($"{str[i]}, ");
    }
    WriteLine($"{str[str.Length - 1]}\n");
}