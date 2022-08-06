using System;
using static System.Console;
Clear();

string[] newString = new string[5];
for (int i = 0; i < 5; i++)
{
    newString[i] = ReadLine();
}
PrintString(newString);
PrintString(DropoutString(newString));

string[] DropoutString(string[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3) count++;
    }
    string[] resultString = new string[count];
    int ctr = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            resultString[ctr] = str[i];
            ctr++;
        }
    }
    return resultString;
}

void PrintString(string[] str)
{
    for (int i = 0; i < str.Length - 1; i++)
    {
        Write($"{str[i]} ");
    }
    WriteLine($"{str[str.Length - 1]}\n");
}